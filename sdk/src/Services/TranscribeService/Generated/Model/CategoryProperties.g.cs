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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Provides you with the properties of the Call Analytics category you specified in your
    /// request. This includes the list of rules that define the specified category.
    /// </summary>
    public partial class CategoryProperties
    {
        /// <summary>
        /// Gets and sets the property CategoryName. 
        /// <para>
        /// The name of the Call Analytics category. Category names are case sensitive and must
        /// be unique within an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Checks to see if the CategoryName property is set.
        /// </summary>
        internal bool IsSetCategoryName() => this.CategoryName != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time the specified Call Analytics category was created.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.761000-07:00</c> represents 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property InputType. 
        /// <para>
        /// The input type associated with the specified category. <c>POST_CALL</c> refers to
        /// a category that is applied to batch transcriptions; <c>REAL_TIME</c> refers to a category
        /// that is applied to streaming transcriptions.
        /// </para>
        /// </summary>
        public InputType InputType { get; set; }

        /// <summary>
        /// Checks to see if the InputType property is set.
        /// </summary>
        internal bool IsSetInputType() => this.InputType != null;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The date and time the specified Call Analytics category was last updated.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-05T12:45:32.691000-07:00</c> represents 12:45 PM UTC-7 on May 5, 2022.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The rules used to define a Call Analytics category. Each category can have between
        /// 1 and 20 rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<Rule> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<Rule>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags, each in the form of a key:value pair, assigned to the specified call analytics
        /// category.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
