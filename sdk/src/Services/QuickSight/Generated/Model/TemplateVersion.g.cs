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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A version of a template.
    /// </summary>
    public partial class TemplateVersion
    {
        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that this template version was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataSetConfigurations. 
        /// <para>
        /// Schema of the dataset identified by the placeholder. Any dashboard created from this
        /// template should be bound to new datasets matching the same schema described through
        /// this API operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public List<DataSetConfiguration> DataSetConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSetConfiguration>() : null;

        /// <summary>
        /// Checks to see if the DataSetConfigurations property is set.
        /// </summary>
        internal bool IsSetDataSetConfigurations() => this.DataSetConfigurations != null && (this.DataSetConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Errors associated with this template version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<TemplateError> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<TemplateError>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sheets. 
        /// <para>
        /// A list of the associated sheets with the unique identifier and name of each sheet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<Sheet> Sheets { get; set; } = AWSConfigs.InitializeCollections ? new List<Sheet>() : null;

        /// <summary>
        /// Checks to see if the Sheets property is set.
        /// </summary>
        internal bool IsSetSheets() => this.Sheets != null && (this.Sheets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceEntityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an analysis or template that was used to create
        /// this template.
        /// </para>
        /// </summary>
        public string SourceEntityArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceEntityArn property is set.
        /// </summary>
        internal bool IsSetSourceEntityArn() => this.SourceEntityArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status that is associated with the template.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATION_IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATION_SUCCESSFUL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATION_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_SUCCESSFUL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property ThemeArn. 
        /// <para>
        /// The ARN of the theme associated with this version of the template.
        /// </para>
        /// </summary>
        public string ThemeArn { get; set; }

        /// <summary>
        /// Checks to see if the ThemeArn property is set.
        /// </summary>
        internal bool IsSetThemeArn() => this.ThemeArn != null;

        /// <summary>
        /// Gets and sets the property TopicConfigurations. 
        /// <para>
        /// Schema of the topic identified by the placeholder. Any dashboard created from this
        /// template should be bound to new topics matching the same schema described through
        /// this API operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public List<TopicConfiguration> TopicConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicConfiguration>() : null;

        /// <summary>
        /// Checks to see if the TopicConfigurations property is set.
        /// </summary>
        internal bool IsSetTopicConfigurations() => this.TopicConfigurations != null && (this.TopicConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the template version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? VersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the VersionNumber property is set.
        /// </summary>
        internal bool IsSetVersionNumber() => this.VersionNumber.HasValue;
    }
}
