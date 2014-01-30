using System.Collections.Generic;

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{

    internal class LiteralArrayOptionsUnmarshaller : IUnmarshaller<LiteralArrayOptions, XmlUnmarshallerContext>, IUnmarshaller<LiteralArrayOptions, JsonUnmarshallerContext>
    {
        public LiteralArrayOptions Unmarshall(XmlUnmarshallerContext context)
        {
            LiteralArrayOptions literalArrayOptions = new LiteralArrayOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    //if (context.TestExpression("DefaultValue", targetDepth))
                    //{
                    //    literalOptions.DefaultValue = StringUnmarshaller.GetInstance().Unmarshall(context);

                    //    continue;
                    //}
                    if (context.TestExpression("SearchEnabled", targetDepth))
                    {
                        literalArrayOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("FacetEnabled", targetDepth))
                    {
                        literalArrayOptions.FacetEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        literalArrayOptions.ResultEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return literalArrayOptions;
                }
            }



            return literalArrayOptions;
        }

        public LiteralArrayOptions Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static LiteralArrayOptionsUnmarshaller instance;

        public static LiteralArrayOptionsUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new LiteralArrayOptionsUnmarshaller();

            return instance;
        }
    }
}

