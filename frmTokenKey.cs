using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public partial class frmTokenKey : Form
    {
        public frmTokenKey()
        {
            InitializeComponent();
        }

        private async Task<string> tryHttpClientPost()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("ContentType", "application/x-www-form-urlencoded");
            var values = new Dictionary<string, string>
            {
                  { "client_id", "bOZdxAfCvWZkYdD82sfcp56cOL0a" },
                  { "client_secret", "d5C3PmbGfiyS2dIShOafxxonFIAa" },
                    { "grant_type","client_credentials" }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://lgsp.danang.gov.vn/token", content);
            return await response.Content.ReadAsStringAsync();
        }
      
        private async Task<string> tryHttpClientGetSoDienThoai(string access_token, string soDienThoai)
        {
            using (var client = new HttpClient())
            {
                var url = "https://lgsp.danang.gov.vn/dng/khaibaoyte/1.0/quanlythongtin/getThongTinKhaiBaoYTe/soDienThoai?soDienThoai=" + soDienThoai;
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + access_token);
                var response = await client.GetStringAsync(url);
                return await client.GetStringAsync(url);
            }
        }

        private async Task<string> tryHttpClientGetSoCMND(string access_token, string soCMND)
        {
            using (var client = new HttpClient())
            {
                var url = "https://lgsp.danang.gov.vn/dng/khaibaoyte/1.0/quanlythongtin/getThongTinKhaiBaoYTe/soCMND?soCMND=" + soCMND;
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + access_token);
                return await client.GetStringAsync(url);
            }
        }
     
        private Token ConvertJSONtoToken(string JSONStr)
            {         
            Token token = new Token();
            if (!((JSONStr == null)||(JSONStr == "")))
            {
                try
                {
                   
                    token = JsonSerializer.Deserialize<Token>(JSONStr);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "check again");
                } 
            }
            return token;
        }
        private async void frmTokenKey_Load(object sender, EventArgs e)
        {
            var responseStringPost = await tryHttpClientPost();
            lblResponse.Text = responseStringPost;
            lblPostJSON.Text = "JSON" + responseStringPost;
            lblPostObejct.Text = "Objebt " + ConvertJSONtoToken(responseStringPost).ToString();
            Token token = new Token();
            string response = lblResponse.Text;
            token = ConvertJSONtoToken(response);
            txtTokenAccess.Text = token.access_token;
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var responseStringPost = await tryHttpClientPost();
            lblResponse.Text = responseStringPost;
            lblPostJSON.Text = "JSON" + responseStringPost;
            lblPostObejct.Text = "Objebt " + ConvertJSONtoToken(responseStringPost).ToString();
        }
     
        private void btnGetToken_Click(object sender, EventArgs e)
        {
            Token token = new Token();
            string response = lblResponse.Text;
            token = ConvertJSONtoToken(response);
            txtTokenAccess.Text = token.access_token;

        }

        private async void btnAll_Click(object sender, EventArgs e)
        {
            var responseStringPost = await tryHttpClientPost();
            lblResponse.Text = responseStringPost;
            lblPostJSON.Text = "JSON" + responseStringPost;
            lblPostObejct.Text = "Objebt " + ConvertJSONtoToken(responseStringPost).ToString();
            Token token = new Token();
            string response = lblResponse.Text;
            token = ConvertJSONtoToken(response);
            txtTokenAccess.Text = token.access_token;
        }

        private async void btnSoDienThoai_Click(object sender, EventArgs e)
        {
            try
            {
                var responseSoDienThoai = await tryHttpClientGetSoDienThoai(txtTokenAccess.Text, txtSoDienThoai.Text);
                List<NguoiKhaiBao> nguoiKhaiBaoList = new List<NguoiKhaiBao>();
                nguoiKhaiBaoList = JsonSerializer.Deserialize<List<NguoiKhaiBao>>(responseSoDienThoai);
                txtKetQuaSoDienThoai.Text = responseSoDienThoai;
                lsvSoDienThoai.Items.Clear();
                foreach (NguoiKhaiBao item in nguoiKhaiBaoList)
                {
                    string[] arr = new string[11];
                    arr[0] = item.id.ToString();
                    arr[1] = (item.hoVaTen != null) ? item.hoVaTen.ToString() : null;

                    if(item.gioiTinhId != null)
                    {
                     
                            if (item.gioiTinhId == 1) arr[2] = "Nam";
                            else arr[2] = "Nữ";
                        
                    }
                    else
                    {
                        arr[2] = null;
                    }

                    arr[3] = (item.diaChiNoiDen != null) ? item.diaChiNoiDen.ToString() : null;              
                    arr[4] = (item.soDienThoai != null) ? item.soDienThoai.ToString() : null;
                    arr[5] = (item.ngaySua != null) ? item.ngaySua.ToString() : null;
                    arr[6] = item.quocTichId.ToString();
                    arr[7] = (item.ngaySinh != null) ? item.ngaySinh.ToString() : null;
                    arr[8] = (item.soCMND != null) ? item.soCMND.ToString() : null;
                    arr[9] = (item.noiCuTruChiTiet != null) ? item.noiCuTruChiTiet.ToString() : null;
                    arr[10] = (item.nguoiKhaiTuDonViId != null) ? item.nguoiKhaiTuDonViId.ToString() : null;
                    ListViewItem listView = new ListViewItem(arr);
                    lsvSoDienThoai.Items.Add(listView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "check again");
            }
        }

        private async void btnSoCMND_Click(object sender, EventArgs e)
        {
            try
            {
                var responseSoCMND = await tryHttpClientGetSoCMND(txtTokenAccess.Text, txtSoCMND.Text);
                List<NguoiKhaiBao> nguoiKhaiBaoList = new List<NguoiKhaiBao>();
                nguoiKhaiBaoList = JsonSerializer.Deserialize<List<NguoiKhaiBao>>(responseSoCMND);
                txtKetQuaSoCMND.Text = responseSoCMND;
                int i = 0;
                lsvSoCMND.Items.Clear();
                foreach (NguoiKhaiBao item in nguoiKhaiBaoList)
                {
                   
                    i++;
                    string[] arr = new string[9];
                    arr[0] = item.id.ToString();
                    arr[1] = (item.hoVaTen != null) ? item.hoVaTen.ToString() : null;
                    arr[2] = (item.diaChiNoiDen != null) ? item.diaChiNoiDen.ToString() : null;
                    arr[3] = (item.soDienThoai != null) ? item.soDienThoai.ToString() : null;
                    arr[4] = (item.ngaySua != null) ? item.ngaySua.ToString() : null;
                    arr[5] = item.quocTichId.ToString();
                    arr[6] = (item.ngaySinh != null) ? item.ngaySinh.ToString() : null;
                    arr[7] = (item.soCMND != null) ? item.soCMND.ToString() : null;
                    arr[8] = (item.noiCuTruChiTiet != null) ? item.noiCuTruChiTiet.ToString() : null;
                    ListViewItem listView = new ListViewItem(arr);
                    lsvSoCMND.Items.Add(listView);            
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "check again");
            }
        }

    
    }
}
