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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// This is the response object from the GetApplicationVersion operation.
    /// </summary>
    public partial class GetApplicationVersionResponse : AmazonWebServiceResponse
    {
        private int? _applicationVersion;
        private DateTime? _creationTime;
        private string _definitionContent;
        private string _description;
        private string _name;
        private ApplicationVersionLifecycle _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property ApplicationVersion. 
        /// <para>
        /// The specific version of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int ApplicationVersion
        {
            get { return this._applicationVersion.GetValueOrDefault(); }
            set { this._applicationVersion = value; }
        }

        // Check to see if ApplicationVersion property is set
        internal bool IsSetApplicationVersion()
        {
            return this._applicationVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the application version was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefinitionContent. 
        /// <para>
        /// The content of the application definition. This is a JSON object that contains the
        /// resource configuration and definitions that identify an application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65000)]
        public string DefinitionContent
        {
            get { return this._definitionContent; }
            set { this._definitionContent = value; }
        }

        // Check to see if DefinitionContent property is set
        internal bool IsSetDefinitionContent()
        {
            return this._definitionContent != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The application description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the application version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationVersionLifecycle Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the reported status.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}