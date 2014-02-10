using System.Collections.Generic;

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    internal class DateOptionsUnmarshaller : IUnmarshaller<DateOptions, XmlUnmarshallerContext>, IUnmarshaller<DateOptions, JsonUnmarshallerContext> 
    {
        public DateOptions Unmarshall(XmlUnmarshallerContext context)
        {
            DateOptions dateOptions = new DateOptions();
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
                        dateOptions.DefaultValue = DateTimeUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("SearchEnabled", targetDepth))
                    {
                        dateOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("FacetEnabled", targetDepth))
                    {
                        dateOptions.FacetEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        dateOptions.ResultEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("SortEnabled", targetDepth))
                    {
                        dateOptions.SortEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }


                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return dateOptions;
                }
            }



            return dateOptions;
        }

        public DateOptions Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static DateOptionsUnmarshaller instance;

        public static DateOptionsUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DateOptionsUnmarshaller();

            return instance;
        }
    }
}
