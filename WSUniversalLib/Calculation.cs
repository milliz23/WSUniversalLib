using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            float area = width * length;
            int res = 0;
            float promres = 0;
            if(area<0||res<0)
            {
                return -1;
            }

            switch (productType)
            {
                case 1:
                    {
                         promres = (float)(area * count * 1.1);
                        switch(materialType)
                        {
                            case 1:
                                {
                                    promres = (float)((promres * 100)/ 99.7);
                                    res = (int)Math.Ceiling(promres);
                                    return res;
                                }
                            case 2:
                                {
                                    promres = (float)((promres *100)/99.12);
                                    res = (int)Math.Ceiling(promres);
                                    return res;
                                }
                            default:
                                {
                                    return -1;
                                }
                        }
                    }
                case 2:
                    {
                        promres = (float)(area * count * 2.5);
                        switch (materialType)
                        {
                            case 1:
                                {
                                    promres = (float)((promres * 100) / 99.7);
                                    res = (int)Math.Ceiling(promres);
                                    return res;
                                }
                            case 2:
                                {
                                    promres = (float)((promres * 100) / 99.12);
                                    res = (int)Math.Ceiling(promres);
                                    return res;
                                }
                            default:
                                {
                                    return -1;
                                }
                        }
                    }
                case 3:
                    {
                        promres = (float)(area * count * 8.43);
                        switch (materialType)
                        {
                            case 1:
                                {
                                    promres = (float)((promres * 100) / 99.7);
                                    res = (int)Math.Ceiling(promres);
                                    return res;
                                }
                            case 2:
                                {
                                    promres = (float)((promres * 100) / 99.12);
                                    res = (int)Math.Ceiling(promres);
                                    return res;
                                }
                            default:
                                {
                                    return -1;
                                }
                        }
                    }
                default:
                    {
                        return -1;
                    }

            }
        }
    }
}
