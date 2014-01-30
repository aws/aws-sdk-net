using System.Collections.Generic;

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{

    internal class DoubleArrayOptionsUnmarshaller : IUnmarshaller<DoubleArrayOptions, XmlUnmarshallerContext>, IUnmarshaller<DoubleArrayOptions, JsonUnmarshallerContext>
    {
        public DoubleArrayOptions Unmarshall(XmlUnmarshallerContext context)
        {
            DoubleArrayOptions doubleArrayOptions = new DoubleArrayOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("SearchEnabled", targetDepth))
                    {
                        doubleArrayOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("FacetEnabled", targetDepth))
                    {
                        doubleArrayOptions.FacetEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        doubleArrayOptions.ResultEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return doubleArrayOptions;
                }
            }



            return doubleArrayOptions;
        }

        public DoubleArrayOptions Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static DoubleArrayOptionsUnmarshaller instance;

        public static DoubleArrayOptionsUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DoubleArrayOptionsUnmarshaller();

            return instance;
        }
    }
}

