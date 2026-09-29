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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents all of the attributes of a DataBrew project.
    /// </summary>
    public partial class Project
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time that the project was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who crated the project.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The dataset that the project is to act upon.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last modified the project.
        /// </para>
        /// </summary>
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The last modification date and time for the project.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of a project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OpenDate. 
        /// <para>
        /// The date and time when the project was opened.
        /// </para>
        /// </summary>
        public DateTime? OpenDate { get; set; }

        /// <summary>
        /// Checks to see if the OpenDate property is set.
        /// </summary>
        internal bool IsSetOpenDate() => this.OpenDate.HasValue;

        /// <summary>
        /// Gets and sets the property OpenedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user that opened the project for use.
        /// </para>
        /// </summary>
        public string OpenedBy { get; set; }

        /// <summary>
        /// Checks to see if the OpenedBy property is set.
        /// </summary>
        internal bool IsSetOpenedBy() => this.OpenedBy != null;

        /// <summary>
        /// Gets and sets the property RecipeName. 
        /// <para>
        /// The name of a recipe that will be developed during a project session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string RecipeName { get; set; }

        /// <summary>
        /// Checks to see if the RecipeName property is set.
        /// </summary>
        internal bool IsSetRecipeName() => this.RecipeName != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role that will be assumed for this project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Sample. 
        /// <para>
        /// The sample size and sampling type to apply to the data. If this parameter isn't specified,
        /// then the sample consists of the first 500 rows from the dataset.
        /// </para>
        /// </summary>
        public Sample Sample { get; set; }

        /// <summary>
        /// Checks to see if the Sample property is set.
        /// </summary>
        internal bool IsSetSample() => this.Sample != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata tags that have been applied to the project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
