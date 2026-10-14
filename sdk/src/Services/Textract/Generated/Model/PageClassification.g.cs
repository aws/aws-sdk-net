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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// The class assigned to a Page object detected in an input document. Contains information
    /// regarding the predicted type/class of a document's page and the page number that the
    /// Page object was detected on.
    /// </summary>
    public partial class PageClassification
    {
        /// <summary>
        /// Gets and sets the property PageNumber. 
        /// <para>
        ///  The page number the value was detected on, relative to Amazon Textract's starting
        /// position.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Prediction> PageNumber { get; set; } = AWSConfigs.InitializeCollections ? new List<Prediction>() : null;

        /// <summary>
        /// Checks to see if the PageNumber property is set.
        /// </summary>
        internal bool IsSetPageNumber() => this.PageNumber != null && (this.PageNumber.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PageType. 
        /// <para>
        /// The class, or document type, assigned to a detected Page object. The class, or document
        /// type, assigned to a detected Page object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Prediction> PageType { get; set; } = AWSConfigs.InitializeCollections ? new List<Prediction>() : null;

        /// <summary>
        /// Checks to see if the PageType property is set.
        /// </summary>
        internal bool IsSetPageType() => this.PageType != null && (this.PageType.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
