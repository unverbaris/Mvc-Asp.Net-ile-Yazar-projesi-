using BusinessLayer.Abstract;
using DataAccessLayer.Absract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal; //constructor method ile  istediğimiz interface ulaşalım ki atamaları gerçekleştirelim sağ tıkla writermanager generate constructor çıkıyor ekle

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal ?? throw new ArgumentNullException(nameof(writerDal));
        }

        public Writer GetByID(int id)
        {
            return _writerDal.Get(x => x.WriterID == id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();
        }

        public void WriterAdd(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void WriterDelete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
