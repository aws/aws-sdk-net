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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the CreateOptOutList operation.
    /// </summary>
    public partial class CreateOptOutListResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the pool was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property OptOutListArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the OptOutList.
        /// </para>
        /// </summary>
        public string OptOutListArn { get; set; }

        /// <summary>
        /// Checks to see if the OptOutListArn property is set.
        /// </summary>
        internal bool IsSetOptOutListArn() => this.OptOutListArn != null;

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The name of the new OptOutList.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string OptOutListName { get; set; }

        /// <summary>
        /// Checks to see if the OptOutListName property is set.
        /// </summary>
        internal bool IsSetOptOutListName() => this.OptOutListName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tags (key and value pairs) associated with the new OptOutList.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
