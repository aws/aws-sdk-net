/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides summary information for an endpoint.
    /// </summary>
    public partial class EndpointSummary
    {
        private DateTime? _creationTime;
        private string _endpointArn;
        private string _endpointName;
        private EndpointStatus _endpointStatus;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the endpoint was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint.
        /// </para>
        /// </summary>
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint.
        /// </para>
        /// </summary>
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointStatus. 
        /// <para>
        /// The status of the endpoint.
        /// </para>
        /// </summary>
        public EndpointStatus EndpointStatus
        {
            get { return this._endpointStatus; }
            set { this._endpointStatus = value; }
        }

        // Check to see if EndpointStatus property is set
        internal bool IsSetEndpointStatus()
        {
            return this._endpointStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that shows when the endpoint was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}