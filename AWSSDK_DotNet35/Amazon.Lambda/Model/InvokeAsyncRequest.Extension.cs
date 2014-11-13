using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Util;

namespace Amazon.Lambda.Model
{
    public partial class InvokeAsyncRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property InvokeArgs. When this property is set the InvokeArgsStream
        /// property is also set with a MemoryStream containing the contents InvokeArgs
        /// <para>
        /// JSON that you want to provide to your cloud function as input.
        /// </para>
        /// </summary>
        public string InvokeArgs
        {
            get
            {
                string content = null;
                if (this.InvokeArgsStream != null)
                {
                    content = new StreamReader(this.InvokeArgsStream).ReadToEnd();
                    this.InvokeArgsStream.Position = 0;
                }
                return content;
            }
            set
            {
                if (value == null)
                    this.InvokeArgsStream = null;
                else
                    this.InvokeArgsStream = AWSSDKUtils.GenerateStreamFromString(value);
            }
        }
    }
}