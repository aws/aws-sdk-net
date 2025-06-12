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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Alert configuration parameters.
    /// </summary>
    public partial class Alert
    {
        private string _alertCode;
        private string _alertMessage;
        private AlertCategory _category;
        private DateTime? _lastModifiedTime;
        private List<string> _relatedResourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property AlertCode. 
        /// <para>
        /// The code for the alert. For example, <c>NOT_PROCESSED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AlertCode
        {
            get { return this._alertCode; }
            set { this._alertCode = value; }
        }

        // Check to see if AlertCode property is set
        internal bool IsSetAlertCode()
        {
            return this._alertCode != null;
        }

        /// <summary>
        /// Gets and sets the property AlertMessage. 
        /// <para>
        /// If an alert is generated for a resource, an explanation of the reason for the alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AlertMessage
        {
            get { return this._alertMessage; }
            set { this._alertMessage = value; }
        }

        // Check to see if AlertMessage property is set
        internal bool IsSetAlertMessage()
        {
            return this._alertMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category that MediaTailor assigns to the alert.
        /// </para>
        /// </summary>
        public AlertCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when the alert was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelatedResourceArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) related to this alert.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RelatedResourceArns
        {
            get { return this._relatedResourceArns; }
            set { this._relatedResourceArns = value; }
        }

        // Check to see if RelatedResourceArns property is set
        internal bool IsSetRelatedResourceArns()
        {
            return this._relatedResourceArns != null && (this._relatedResourceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}