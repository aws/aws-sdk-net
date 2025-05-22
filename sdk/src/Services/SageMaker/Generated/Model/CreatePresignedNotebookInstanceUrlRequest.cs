/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePresignedNotebookInstanceUrl operation.
    /// Returns a URL that you can use to connect to the Jupyter server from a notebook instance.
    /// In the SageMaker AI console, when you choose <c>Open</c> next to a notebook instance,
    /// SageMaker AI opens a new tab showing the Jupyter server home page from the notebook
    /// instance. The console uses this API to get the URL and show the page.
    /// 
    ///  
    /// <para>
    ///  The IAM role or user used to call this API defines the permissions to access the
    /// notebook instance. Once the presigned URL is created, no additional permission is
    /// required to access this URL. IAM authorization policies for this API are also enforced
    /// for every HTTP request and WebSocket frame that attempts to connect to the notebook
    /// instance.
    /// </para>
    ///  
    /// <para>
    /// You can restrict access to this API and to the URL that it returns to a list of IP
    /// addresses that you specify. Use the <c>NotIpAddress</c> condition operator and the
    /// <c>aws:SourceIP</c> condition context key to specify the list of IP addresses that
    /// you want to have access to the notebook instance. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/security_iam_id-based-policy-examples.html#nbi-ip-filter">Limit
    /// Access to a Notebook Instance by IP Address</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The URL that you get from a call to <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreatePresignedNotebookInstanceUrl.html">CreatePresignedNotebookInstanceUrl</a>
    /// is valid only for 5 minutes. If you try to use the URL after the 5-minute limit expires,
    /// you are directed to the Amazon Web Services console sign-in page.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePresignedNotebookInstanceUrlRequest : AmazonSageMakerRequest
    {
        private string _notebookInstanceName;
        private int? _sessionExpirationDurationInSeconds;

        /// <summary>
        /// Gets and sets the property NotebookInstanceName. 
        /// <para>
        /// The name of the notebook instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string NotebookInstanceName
        {
            get { return this._notebookInstanceName; }
            set { this._notebookInstanceName = value; }
        }

        // Check to see if NotebookInstanceName property is set
        internal bool IsSetNotebookInstanceName()
        {
            return this._notebookInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property SessionExpirationDurationInSeconds. 
        /// <para>
        /// The duration of the session, in seconds. The default is 12 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1800, Max=43200)]
        public int? SessionExpirationDurationInSeconds
        {
            get { return this._sessionExpirationDurationInSeconds; }
            set { this._sessionExpirationDurationInSeconds = value; }
        }

        // Check to see if SessionExpirationDurationInSeconds property is set
        internal bool IsSetSessionExpirationDurationInSeconds()
        {
            return this._sessionExpirationDurationInSeconds.HasValue; 
        }

    }
}