using System.Collections.Generic;

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{

    internal class DateArrayOptionsUnmarshaller : IUnmarshaller<DateArrayOptions, XmlUnmarshallerContext>, IUnmarshaller<DateArrayOptions, JsonUnmarshallerContext>
    {
        public DateArrayOptions Unmarshall(XmlUnmarshallerContext context)
        {
            DateArrayOptions DateArrayOptions = new DateArrayOptions();
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
                        DateArrayOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("FacetEnabled", targetDepth))
                    {
                        DateArrayOptions.FacetEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        DateArrayOptions.ResultEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return DateArrayOptions;
                }
            }



            return DateArrayOptions;
        }

        public DateArrayOptions Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static DateArrayOptionsUnmarshaller instance;

        public static DateArrayOptionsUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DateArrayOptionsUnmarshaller();

            return instance;
        }
    }
}

