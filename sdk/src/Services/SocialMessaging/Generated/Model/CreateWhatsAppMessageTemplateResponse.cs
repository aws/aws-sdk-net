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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// This is the response object from the CreateWhatsAppMessageTemplate operation.
    /// </summary>
    public partial class CreateWhatsAppMessageTemplateResponse : AmazonWebServiceResponse
    {
        private string _category;
        private string _metaTemplateId;
        private string _templateStatus;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the template, such as UTILITY or MARKETING.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Category
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
        /// Gets and sets the property MetaTemplateId. 
        /// <para>
        /// The numeric ID assigned to the template by Meta.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string MetaTemplateId
        {
            get { return this._metaTemplateId; }
            set { this._metaTemplateId = value; }
        }

        // Check to see if MetaTemplateId property is set
        internal bool IsSetMetaTemplateId()
        {
            return this._metaTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateStatus. 
        /// <para>
        /// The status of the created template, such as PENDING or APPROVED..
        /// </para>
        /// </summary>
        public string TemplateStatus
        {
            get { return this._templateStatus; }
            set { this._templateStatus = value; }
        }

        // Check to see if TemplateStatus property is set
        internal bool IsSetTemplateStatus()
        {
            return this._templateStatus != null;
        }

    }
}