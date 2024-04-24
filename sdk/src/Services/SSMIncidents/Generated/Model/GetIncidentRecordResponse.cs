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
    /// This is the response object from the GetIncidentRecord operation.
    /// </summary>
    public partial class GetIncidentRecordResponse : AmazonWebServiceResponse
    {
        private IncidentRecord _incidentRecord;

        /// <summary>
        /// Gets and sets the property IncidentRecord. 
        /// <para>
        /// Details the structure of the incident record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IncidentRecord IncidentRecord
        {
            get { return this._incidentRecord; }
            set { this._incidentRecord = value; }
        }

        // Check to see if IncidentRecord property is set
        internal bool IsSetIncidentRecord()
        {
            return this._incidentRecord != null;
        }

    }
}