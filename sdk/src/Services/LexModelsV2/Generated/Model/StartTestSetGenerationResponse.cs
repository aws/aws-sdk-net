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
    /// This is the response object from the StartTestSetGeneration operation.
    /// </summary>
    public partial class StartTestSetGenerationResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationDateTime;
        private string _description;
        private TestSetGenerationDataSource _generationDataSource;
        private string _roleArn;
        private TestSetStorageLocation _storageLocation;
        private string _testSetGenerationId;
        private TestSetGenerationStatus _testSetGenerationStatus;
        private string _testSetName;
        private Dictionary<string, string> _testSetTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        ///  The creation date and time for the test set generation.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description used for the test set generation.
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
        ///  The data source for the test set generation.
        /// </para>
        /// </summary>
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
        [AWSProperty(Min=32, Max=2048)]
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
        /// Gets and sets the property TestSetGenerationId. 
        /// <para>
        /// The unique identifier of the test set generation to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string TestSetGenerationId
        {
            get { return this._testSetGenerationId; }
            set { this._testSetGenerationId = value; }
        }

        // Check to see if TestSetGenerationId property is set
        internal bool IsSetTestSetGenerationId()
        {
            return this._testSetGenerationId != null;
        }

        /// <summary>
        /// Gets and sets the property TestSetGenerationStatus. 
        /// <para>
        ///  The status for the test set generation.
        /// </para>
        /// </summary>
        public TestSetGenerationStatus TestSetGenerationStatus
        {
            get { return this._testSetGenerationStatus; }
            set { this._testSetGenerationStatus = value; }
        }

        // Check to see if TestSetGenerationStatus property is set
        internal bool IsSetTestSetGenerationStatus()
        {
            return this._testSetGenerationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TestSetName. 
        /// <para>
        /// The test set name used for the test set generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// A list of tags that was used for the test set that is being generated.
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