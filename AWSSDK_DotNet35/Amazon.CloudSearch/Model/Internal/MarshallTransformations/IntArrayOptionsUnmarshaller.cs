using System.Collections.Generic;

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{

    internal class IntArrayOptionsUnmarshaller : IUnmarshaller<IntArrayOptions, XmlUnmarshallerContext>, IUnmarshaller<IntArrayOptions, JsonUnmarshallerContext>
    {
        public IntArrayOptions Unmarshall(XmlUnmarshallerContext context)
        {
            IntArrayOptions intArrayOptions = new IntArrayOptions();
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
                        intArrayOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("FacetEnabled", targetDepth))
                    {
                        intArrayOptions.FacetEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        intArrayOptions.ResultEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return intArrayOptions;
                }
            }



            return intArrayOptions;
        }

        public IntArrayOptions Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static IntArrayOptionsUnmarshaller instance;

        public static IntArrayOptionsUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new IntArrayOptionsUnmarshaller();

            return instance;
        }
    }
}

