namespace api.Interfaces
{
    public interface IDeleteSong
    {
        public void Delete(int id);
        public void DropTable();
    }
}