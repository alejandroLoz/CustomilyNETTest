using CutomilyNetCoreTest.Models;

namespace CutomilyNetCoreTest.Services
{
    public interface IPageService
    {
        void SavePage(PageViewModel page);
        List<string> GetTitlesByxy(double x, double y);
    }
}
