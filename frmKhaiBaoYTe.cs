using System;
using System.Collections.Generic;

using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using System.Threading;


using System.Net;
using System.Text;  // For class Encoding
using System.IO;    // For StreamReader
using System.Threading.Tasks;
using System.Net.Http.Headers;
namespace WindowsFormsApp1
{
    public partial class frmKhaiBaoYTe : Form
    {
        public frmKhaiBaoYTe()
        {
            InitializeComponent();
        }

        private async Task<string> tryHttpClientPost()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("ContentType", "application/x-www-form-urlencoded");
            var values = new Dictionary<string, string>
            {
                  { "client_id", "gT96lY2sJrOXbtB6tOHPAA1Wb5ka" },
                  { "client_secret", "M9UFifmV6RbUpMZDdd4RT34fUzwa" },
                    { "grant_type", "client_credentials" }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://lgsp.danang.gov.vn/token", content);
            return await response.Content.ReadAsStringAsync();
        }

        private async Task<string> tryHttpClientPostKhaiBaoYTe(string access_token, NguoiKhaiBao nguoiKhaiBao)
        {
            //NguoiKhaiBao nguoiKhaiBaoTest = new NguoiKhaiBao();
            //nguoiKhaiBaoTest.hoVaTen = "BVUB Test";
            //nguoiKhaiBaoTest.noiDenGhiChu = null;
            //nguoiKhaiBaoTest.coTiepXucCovid = null;
            //nguoiKhaiBaoTest.coTrieuChungCovid = false;
            //nguoiKhaiBaoTest.diaChiNoiDen = "11 Lâm Nhĩ";
            //nguoiKhaiBaoTest.soDienThoai = "0932254044";
            //nguoiKhaiBaoTest.email = null;
            //nguoiKhaiBaoTest.bienSoXe = null;
            //nguoiKhaiBaoTest.trieuChungId = null;
            //nguoiKhaiBaoTest.trieuChungKhac = null;
            //nguoiKhaiBaoTest.benhManTinhId = "5";
            //nguoiKhaiBaoTest.benhManTinhKhac = null;
            //nguoiKhaiBaoTest.soNgayLuuTru = 0;
            //nguoiKhaiBaoTest.gioiTinhId = 1;
            //nguoiKhaiBaoTest.quocTichId = 1;
            //nguoiKhaiBaoTest.ngaySinh = "1993-10-21";
            //nguoiKhaiBaoTest.soCMND = "201667222";
            //nguoiKhaiBaoTest.laDenDaNang = false;
            //nguoiKhaiBaoTest.laKhaiHo = false;
            //nguoiKhaiBaoTest.noiCuTruChiTiet = "abc";
            //nguoiKhaiBaoTest.soTheBHYT = null;
            //nguoiKhaiBaoTest.tinhTrangTiepXucId = null;
            //nguoiKhaiBaoTest.coThaiKy = false;
            //nguoiKhaiBaoTest.hinhAnh = null;
            //nguoiKhaiBaoTest.maNoiCuTruTinh = "48";
            //nguoiKhaiBaoTest.maNoiCuTruHuyen = "491";
            //nguoiKhaiBaoTest.maNoiCuTruXa = "20203";
            //nguoiKhaiBaoTest.maQuocTich = "VN";
            //nguoiKhaiBaoTest.maNoiDenTinh1 = null;
            //nguoiKhaiBaoTest.maNoiDenHuyen1 = null;
            //nguoiKhaiBaoTest.maNoiDenXa1 = null;
            //nguoiKhaiBaoTest.maNoiDenTinh2 = null;
            //nguoiKhaiBaoTest.maNoiDenHuyen2 = null;
            //nguoiKhaiBaoTest.maNoiDenXa2 = null;
            //nguoiKhaiBaoTest.maNoiOTinh = "48";
            //nguoiKhaiBaoTest.maNoiOHuyen = "491";
            //nguoiKhaiBaoTest.maNoiOXa = "20203";
            //nguoiKhaiBaoTest.maDonVi = "BVUB";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + access_token);
                //var newJSONPost = JsonSerializer.Serialize(nguoiKhaiBaoTest);
                var newJSONPost = JsonSerializer.Serialize(nguoiKhaiBao);
                var payload = new StringContent(newJSONPost, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://lgsp.danang.gov.vn/dng/smartapp/1.0/quanlythongtin", payload);
                var result = await response.Content.ReadAsStringAsync();
                return await response.Content.ReadAsStringAsync();
            }
        }

        private async Task<string> tryHttpClientPostCheckIn(string access_token, NguoiKhaiBao nguoiKhaiBao)
        {
            NguoiKhaiBao nguoiKhaiBaoTest = new NguoiKhaiBao();

            nguoiKhaiBaoTest.hoVaTen = "Test A";
            nguoiKhaiBaoTest.noiDenGhiChu = null;
            nguoiKhaiBaoTest.coTiepXucCovid = null;
            nguoiKhaiBaoTest.coTrieuChungCovid = false;
            nguoiKhaiBaoTest.diaChiNoiDen = "11 Lâm Nhĩ";
            nguoiKhaiBaoTest.soDienThoai = "0932254044";
            nguoiKhaiBaoTest.email = null;
            nguoiKhaiBaoTest.bienSoXe = null;
            nguoiKhaiBaoTest.trieuChungId = null;
            nguoiKhaiBaoTest.trieuChungKhac = null;
            nguoiKhaiBaoTest.benhManTinhId = "5";
            nguoiKhaiBaoTest.benhManTinhKhac = null;
            nguoiKhaiBaoTest.soNgayLuuTru = 0;
            nguoiKhaiBaoTest.gioiTinhId = 1;
            nguoiKhaiBaoTest.quocTichId = 1;
            nguoiKhaiBaoTest.ngaySinh = "1993-10-21";
            nguoiKhaiBaoTest.soCMND = "201667222";
            nguoiKhaiBaoTest.laDenDaNang = false;
            nguoiKhaiBaoTest.laKhaiHo = false;
            nguoiKhaiBaoTest.noiCuTruChiTiet = "abc";
            nguoiKhaiBaoTest.soTheBHYT = null;
            nguoiKhaiBaoTest.tinhTrangTiepXucId = null;
            nguoiKhaiBaoTest.coThaiKy = false;
            nguoiKhaiBaoTest.hinhAnh = null;
            nguoiKhaiBaoTest.maNoiCuTruTinh = "48";
            nguoiKhaiBaoTest.maNoiCuTruHuyen = "491";
            nguoiKhaiBaoTest.maNoiCuTruXa = "20203";
            nguoiKhaiBaoTest.maQuocTich = "VN";
            nguoiKhaiBaoTest.maNoiDenTinh1 = null;
            nguoiKhaiBaoTest.maNoiDenHuyen1 = null;
            nguoiKhaiBaoTest.maNoiDenXa1 = null;
            nguoiKhaiBaoTest.maNoiDenTinh2 = null;
            nguoiKhaiBaoTest.maNoiDenHuyen2 = null;
            nguoiKhaiBaoTest.maNoiDenXa2 = null;
            nguoiKhaiBaoTest.maNoiOTinh = "48";
            nguoiKhaiBaoTest.maNoiOHuyen = "491";
            nguoiKhaiBaoTest.maNoiOXa = "20203";
            nguoiKhaiBaoTest.maDonVi = "BVUB";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + access_token);
                var newJSONPost = JsonSerializer.Serialize(nguoiKhaiBaoTest);
                var payload = new StringContent(newJSONPost, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://lgsp.danang.gov.vn/dng/smartapp/1.0/quanlythongtin/checkin", payload);
                var result = await response.Content.ReadAsStringAsync();

                return await response.Content.ReadAsStringAsync();
            }
        }

        private Token ConvertJSONtoToken(string JSONStr)
        {
            Token token = new Token();
            if (!((JSONStr == null) || (JSONStr == "")))
            {
                try
                {
                    token = JsonSerializer.Deserialize<Token>(JSONStr);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "check again");
                }
            }
            return token;
        }


        private async void btnPost_Click(object sender, EventArgs e)
        {
            var responseStringPost = await tryHttpClientPost();
            lblResponse.Text = responseStringPost;
            lblPostJSON.Text = "JSON: " + responseStringPost;
            lblPostObejct.Text = "Object:  " + ConvertJSONtoToken(responseStringPost).ToString();
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
            lblPostJSON.Text = "JSON: " + responseStringPost;
            lblPostObejct.Text = "Object: " + ConvertJSONtoToken(responseStringPost).ToString();
            Token token = new Token();
            string response = lblResponse.Text;
            token = ConvertJSONtoToken(response);
            txtTokenAccess.Text = token.access_token;
        }


        private async void frmKhaiBaoYTe_Load(object sender, EventArgs e)
        {
            var responseStringPost = await tryHttpClientPost();
            lblResponse.Text = responseStringPost;
            lblPostJSON.Text = "JSON: " + responseStringPost;
            lblPostObejct.Text = "Object " + ConvertJSONtoToken(responseStringPost).ToString();
            Token token = new Token();
            string response = lblResponse.Text;
            token = ConvertJSONtoToken(response);
            txtTokenAccess.Text = token.access_token;
        }

        private async void btnPostKhaiBaoYTe_Click(object sender, EventArgs e)
        {
            var responseStringPost = await tryHttpClientPost();
            lblResponse.Text = responseStringPost;
            lblPostJSON.Text = "JSON: " + responseStringPost;
            lblPostObejct.Text = "Object " + ConvertJSONtoToken(responseStringPost).ToString();
            Token token = new Token();
            string response = lblResponse.Text;
            token = ConvertJSONtoToken(response);
            txtTokenAccess.Text = token.access_token;

            NguoiKhaiBao nguoiKhaiBao = new NguoiKhaiBao();
            nguoiKhaiBao.hoVaTen = txtHoVaTenKBYT.Text;
            nguoiKhaiBao.coTrieuChungCovid = chkTrieuChungCovidKBYT.Checked;
            nguoiKhaiBao.diaChiNoiDen = txtDiaChiNoiDenKBYT.Text;

            if (rdoNamKBYT.Checked) nguoiKhaiBao.gioiTinhId = 1;
            else nguoiKhaiBao.gioiTinhId = 2;
            nguoiKhaiBao.quocTichId = Convert.ToInt32(txtQuocTichIdKBYT.Text.ToString());
            nguoiKhaiBao.ngaySinh = dtpNgaySinhKBYT.Value.ToString("yyyy-mm-dd");

          
            nguoiKhaiBao.soCMND = txtCMNDKBYT.Text;
            nguoiKhaiBao.laDenDaNang = chkLaDenDNKBYT.Checked;
            nguoiKhaiBao.laKhaiHo = chkLaKhaiHoKBYT.Checked;

            nguoiKhaiBao.noiCuTruChiTiet = txtNoiCuTruChiTietKBYT.Text;

            nguoiKhaiBao.maNoiCuTruTinh = txtMaNoiCuTruTinhKBYT.Text;
            nguoiKhaiBao.maNoiCuTruHuyen = txtMaNoiCuTruHuyenKBYT.Text;
            nguoiKhaiBao.maNoiCuTruXa = txtMaNoiCuTruXaKBYT.Text;

            nguoiKhaiBao.maQuocTich = txtMaQuocTichKBYT.Text;
            nguoiKhaiBao.coThaiKy = chkThaiKyKBYT.Checked;

            nguoiKhaiBao.maNoiOTinh = txtMaNoiOTinhKBYT.Text;
            nguoiKhaiBao.maNoiOHuyen = txtMaNoiOHuyenKBYT.Text;
            nguoiKhaiBao.maNoiOXa = txtMaNoiOXaKBYT.Text;

            nguoiKhaiBao.maDonVi = txtMaDonViKBYT.Text;
          


            var responseStringPostKhaiBaoYTe = await tryHttpClientPostKhaiBaoYTe( txtTokenAccess.Text.ToString(), nguoiKhaiBao);
            txtResponseStringPostKhaiBaoYTe.Text = responseStringPostKhaiBaoYTe;

        }

        private async void btnPostCheckIn_Click(object sender, EventArgs e)
        {
            NguoiKhaiBao nguoiKhaiBao = new NguoiKhaiBao();
            var responseStringPostCheckIn = await tryHttpClientPostCheckIn(txtTokenAccess.Text.ToString(), nguoiKhaiBao);
            txtResponseStringPostCheckIn.Text = responseStringPostCheckIn;
        }

    
    }
}
