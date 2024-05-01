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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Details about what created the incident record and when it was created.
    /// </summary>
    public partial class IncidentRecordSource
    {
        private string _createdBy;
        private string _invokedBy;
        private string _resourceArn;
        private string _source;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The principal that started the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property InvokedBy. 
        /// <para>
        /// The service principal that assumed the role specified in <c>createdBy</c>. If no service
        /// principal assumed the role this will be left blank.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string InvokedBy
        {
            get { return this._invokedBy; }
            set { this._invokedBy = value; }
        }

        // Check to see if InvokedBy property is set
        internal bool IsSetInvokedBy()
        {
            return this._invokedBy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The resource that caused the incident to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The service that started the incident. This can be manually created from Incident
        /// Manager, automatically created using an Amazon CloudWatch alarm, or Amazon EventBridge
        /// event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}