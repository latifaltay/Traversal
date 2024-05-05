﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feature t)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetAll()
        {
            return _featureDal.GetAll();
        }

        public Feature GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
