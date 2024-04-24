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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the ImportNotebook operation.
    /// Imports a single <c>ipynb</c> file to a Spark enabled workgroup. To import the notebook,
    /// the request must specify a value for either <c>Payload</c> or <c>NoteBookS3LocationUri</c>.
    /// If neither is specified or both are specified, an <c>InvalidRequestException</c> occurs.
    /// The maximum file size that can be imported is 10 megabytes. If an <c>ipynb</c> file
    /// with the same name already exists in the workgroup, throws an error.
    /// </summary>
    public partial class ImportNotebookRequest : AmazonAthenaRequest
    {
        private string _clientRequestToken;
        private string _name;
        private string _notebookS3LocationUri;
        private string _payload;
        private NotebookType _type;
        private string _workGroup;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique case-sensitive string used to ensure the request to import the notebook is
        /// idempotent (executes only once).
        /// </para>
        ///  <important> 
        /// <para>
        /// This token is listed as not required because Amazon Web Services SDKs (for example
        /// the Amazon Web Services SDK for Java) auto-generate the token for you. If you are
        /// not using the Amazon Web Services SDK or the Amazon Web Services CLI, you must provide
        /// this token or the action will fail.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the notebook to import.
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

        /// <summary>
        /// Gets and sets the property NotebookS3LocationUri. 
        /// <para>
        /// A URI that specifies the Amazon S3 location of a notebook file in <c>ipynb</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string NotebookS3LocationUri
        {
            get { return this._notebookS3LocationUri; }
            set { this._notebookS3LocationUri = value; }
        }

        // Check to see if NotebookS3LocationUri property is set
        internal bool IsSetNotebookS3LocationUri()
        {
            return this._notebookS3LocationUri != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The notebook content to be imported. The payload must be in <c>ipynb</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10485760)]
        public string Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The notebook content type. Currently, the only valid type is <c>IPYNB</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotebookType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The name of the Spark enabled workgroup to import the notebook to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkGroup
        {
            get { return this._workGroup; }
            set { this._workGroup = value; }
        }

        // Check to see if WorkGroup property is set
        internal bool IsSetWorkGroup()
        {
            return this._workGroup != null;
        }

    }
}