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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
    /// Container for the parameters to the StartTestSetGeneration operation.
    /// The action to start the generation of test set.
    /// </summary>
    public partial class StartTestSetGenerationRequest : AmazonLexModelsV2Request
    {
        private string _description;
        private TestSetGenerationDataSource _generationDataSource;
        private string _roleArn;
        private TestSetStorageLocation _storageLocation;
        private string _testSetName;
        private Dictionary<string, string> _testSetTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The test set description for the test set generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GenerationDataSource. 
        /// <para>
        /// The data source for the test set generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestSetGenerationDataSource GenerationDataSource
        {
            get { return this._generationDataSource; }
            set { this._generationDataSource = value; }
        }

        // Check to see if GenerationDataSource property is set
        internal bool IsSetGenerationDataSource()
        {
            return this._generationDataSource != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The roleARN used for any operation in the test set to access resources in the Amazon
        /// Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// The Amazon S3 storage location for the test set generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestSetStorageLocation StorageLocation
        {
            get { return this._storageLocation; }
            set { this._storageLocation = value; }
        }

        // Check to see if StorageLocation property is set
        internal bool IsSetStorageLocation()
        {
            return this._storageLocation != null;
        }

        /// <summary>
        /// Gets and sets the property TestSetName. 
        /// <para>
        /// The test set name for the test set generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TestSetName
        {
            get { return this._testSetName; }
            set { this._testSetName = value; }
        }

        // Check to see if TestSetName property is set
        internal bool IsSetTestSetName()
        {
            return this._testSetName != null;
        }

        /// <summary>
        /// Gets and sets the property TestSetTags. 
        /// <para>
        /// A list of tags to add to the test set. You can only add tags when you import/generate
        /// a new test set. You can't use the <c>UpdateTestSet</c> operation to update tags. To
        /// update tags, use the <c>TagResource</c> operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> TestSetTags
        {
            get { return this._testSetTags; }
            set { this._testSetTags = value; }
        }

        // Check to see if TestSetTags property is set
        internal bool IsSetTestSetTags()
        {
            return this._testSetTags != null && (this._testSetTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}