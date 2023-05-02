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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRelatedItems operation.
    /// Add or remove related items from the related items tab of an incident record.
    /// </summary>
    public partial class UpdateRelatedItemsRequest : AmazonSSMIncidentsRequest
    {
        private string _clientToken;
        private string _incidentRecordArn;
        private RelatedItemsUpdate _relatedItemsUpdate;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures that a client calls the operation only once with the specified
        /// details.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property IncidentRecordArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident record that contains the related items
        /// that you update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string IncidentRecordArn
        {
            get { return this._incidentRecordArn; }
            set { this._incidentRecordArn = value; }
        }

        // Check to see if IncidentRecordArn property is set
        internal bool IsSetIncidentRecordArn()
        {
            return this._incidentRecordArn != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedItemsUpdate. 
        /// <para>
        /// Details about the item that you are add to, or delete from, an incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelatedItemsUpdate RelatedItemsUpdate
        {
            get { return this._relatedItemsUpdate; }
            set { this._relatedItemsUpdate = value; }
        }

        // Check to see if RelatedItemsUpdate property is set
        internal bool IsSetRelatedItemsUpdate()
        {
            return this._relatedItemsUpdate != null;
        }

    }
}