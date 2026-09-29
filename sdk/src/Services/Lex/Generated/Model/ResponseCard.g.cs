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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Lex.Model
{
    /// <summary>
    /// If you configure a response card when creating your bots, Amazon Lex substitutes the
    /// session attributes and slot values that are available, and then returns it. The response
    /// card can also come from a Lambda function ( <c>dialogCodeHook</c> and <c>fulfillmentActivity</c>
    /// on an intent).
    /// </summary>
    public partial class ResponseCard
    {
        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the response.
        /// </para>
        /// </summary>
        public ContentType ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property GenericAttachments. 
        /// <para>
        /// An array of attachment objects representing options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<GenericAttachment> GenericAttachments { get; set; } = AWSConfigs.InitializeCollections ? new List<GenericAttachment>() : null;

        /// <summary>
        /// Checks to see if the GenericAttachments property is set.
        /// </summary>
        internal bool IsSetGenericAttachments() => this.GenericAttachments != null && (this.GenericAttachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the response card format.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
