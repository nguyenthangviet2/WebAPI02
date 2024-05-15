using WebAPI02.Models.Domain;
using Microsoft.AspNetCore.Http;
namespace WebAPI02.Repositories
{
    public interface IImageRepository
    {
        Image Upload(Image image);
        List<Image> GetAllInfoImages();
        (byte[], string, string) DownloadFile(int Id);
    }
}
