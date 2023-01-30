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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the StartImportTask operation.
    /// Starts an import task, which allows you to import details of your on-premises environment
    /// directly into Amazon Web Services Migration Hub without having to use the Application
    /// Discovery Service (ADS) tools such as the Discovery Connector or Discovery Agent.
    /// This gives you the option to perform migration assessment and planning directly from
    /// your imported data, including the ability to group your devices as applications and
    /// track their migration status.
    /// 
    ///  
    /// <para>
    /// To start an import request, do this:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Download the specially formatted comma separated value (CSV) import template, which
    /// you can find here: <a href="https://s3.us-west-2.amazonaws.com/templates-7cffcf56-bd96-4b1c-b45b-a5b42f282e46/import_template.csv">https://s3.us-west-2.amazonaws.com/templates-7cffcf56-bd96-4b1c-b45b-a5b42f282e46/import_template.csv</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Fill out the template with your server and application data.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Upload your import file to an Amazon S3 bucket, and make a note of it's Object URL.
    /// Your import file must be in the CSV format.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the console or the <code>StartImportTask</code> command with the Amazon Web Services
    /// CLI or one of the Amazon Web Services SDKs to import the records from your file.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information, including step-by-step procedures, see <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/discovery-import.html">Migration
    /// Hub Import</a> in the <i>Amazon Web Services Application Discovery Service User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// There are limits to the number of import tasks you can create (and delete) in an Amazon
    /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/ads_service_limits.html">Amazon
    /// Web Services Application Discovery Service Limits</a> in the <i>Amazon Web Services
    /// Application Discovery Service User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartImportTaskRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private string _clientRequestToken;
        private string _importUrl;
        private string _name;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Optional. A unique token that you can provide to prevent the same import request from
        /// occurring more than once. If you don't provide a token, a token is automatically generated.
        /// </para>
        ///  
        /// <para>
        /// Sending more than one <code>StartImportTask</code> request with the same client request
        /// token will return information about the original import task with that client request
        /// token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ImportUrl. 
        /// <para>
        /// The URL for your import file that you've uploaded to Amazon S3.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're using the Amazon Web Services CLI, this URL is structured as follows: <code>s3://BucketName/ImportFileName.CSV</code>
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4000)]
        public string ImportUrl
        {
            get { return this._importUrl; }
            set { this._importUrl = value; }
        }

        // Check to see if ImportUrl property is set
        internal bool IsSetImportUrl()
        {
            return this._importUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for this request. You can use this name to filter future requests
        /// related to this import task, such as identifying applications and servers that were
        /// included in this import task. We recommend that you use a meaningful name for each
        /// import task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}