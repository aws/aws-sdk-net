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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the StartTestSetGeneration operation.
    /// </summary>
    public partial class StartTestSetGenerationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        ///  The creation date and time for the test set generation.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description used for the test set generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GenerationDataSource. 
        /// <para>
        ///  The data source for the test set generation.
        /// </para>
        /// </summary>
        public TestSetGenerationDataSource GenerationDataSource { get; set; }

        /// <summary>
        /// Checks to see if the GenerationDataSource property is set.
        /// </summary>
        internal bool IsSetGenerationDataSource() => this.GenerationDataSource != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The roleARN used for any operation in the test set to access resources in the Amazon
        /// Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// The Amazon S3 storage location for the test set generation.
        /// </para>
        /// </summary>
        public TestSetStorageLocation StorageLocation { get; set; }

        /// <summary>
        /// Checks to see if the StorageLocation property is set.
        /// </summary>
        internal bool IsSetStorageLocation() => this.StorageLocation != null;

        /// <summary>
        /// Gets and sets the property TestSetGenerationId. 
        /// <para>
        /// The unique identifier of the test set generation to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string TestSetGenerationId { get; set; }

        /// <summary>
        /// Checks to see if the TestSetGenerationId property is set.
        /// </summary>
        internal bool IsSetTestSetGenerationId() => this.TestSetGenerationId != null;

        /// <summary>
        /// Gets and sets the property TestSetGenerationStatus. 
        /// <para>
        ///  The status for the test set generation.
        /// </para>
        /// </summary>
        public TestSetGenerationStatus TestSetGenerationStatus { get; set; }

        /// <summary>
        /// Checks to see if the TestSetGenerationStatus property is set.
        /// </summary>
        internal bool IsSetTestSetGenerationStatus() => this.TestSetGenerationStatus != null;

        /// <summary>
        /// Gets and sets the property TestSetName. 
        /// <para>
        /// The test set name used for the test set generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TestSetName { get; set; }

        /// <summary>
        /// Checks to see if the TestSetName property is set.
        /// </summary>
        internal bool IsSetTestSetName() => this.TestSetName != null;

        /// <summary>
        /// Gets and sets the property TestSetTags. 
        /// <para>
        /// A list of tags that was used for the test set that is being generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> TestSetTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TestSetTags property is set.
        /// </summary>
        internal bool IsSetTestSetTags() => this.TestSetTags != null && (this.TestSetTags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
