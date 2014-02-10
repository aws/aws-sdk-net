using System.Collections.Generic;

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    internal class DoubleOptionsUnmarshaller : IUnmarshaller<DoubleOptions, XmlUnmarshallerContext>, IUnmarshaller<DoubleOptions, JsonUnmarshallerContext> 
    {
        public DoubleOptions Unmarshall(XmlUnmarshallerContext context)
        {
            DoubleOptions doubleOptions = new DoubleOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DefaultValue", targetDepth))
                    {
                        doubleOptions.DefaultValue = DoubleUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("SearchEnabled", targetDepth))
                    {
                        doubleOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("FacetEnabled", targetDepth))
                    {
                        doubleOptions.FacetEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        doubleOptions.ResultEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("SortEnabled", targetDepth))
                    {
                        doubleOptions.SortEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    
                    
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return doubleOptions;
                }
            }



            return doubleOptions;
        }

        public DoubleOptions Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static DoubleOptionsUnmarshaller instance;

        public static DoubleOptionsUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DoubleOptionsUnmarshaller();

            return instance;
        }
    }
}
