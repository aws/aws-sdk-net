using System.Collections.Generic;

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{

    internal class TextArrayOptionsUnmarshaller : IUnmarshaller<TextArrayOptions, XmlUnmarshallerContext>, IUnmarshaller<TextArrayOptions, JsonUnmarshallerContext>
    {
        public TextArrayOptions Unmarshall(XmlUnmarshallerContext context)
        {
            TextArrayOptions textArrayOptions = new TextArrayOptions();
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
                        textArrayOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }

                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        textArrayOptions.ResultEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return textArrayOptions;
                }
            }



            return textArrayOptions;
        }

        public TextArrayOptions Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static TextArrayOptionsUnmarshaller instance;

        public static TextArrayOptionsUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new TextArrayOptionsUnmarshaller();

            return instance;
        }
    }
}

