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
    /// This is the response object from the DescribeImport operation.
    /// </summary>
    public partial class DescribeImportResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationDateTime;
        private List<string> _failureReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _importedResourceId;
        private string _importedResourceName;
        private string _importId;
        private ImportStatus _importStatus;
        private DateTime? _lastUpdatedDateTime;
        private MergeStrategy _mergeStrategy;
        private ImportResourceSpecification _resourceSpecification;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time that the import was created.
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
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// If the <c>importStatus</c> field is <c>Failed</c>, this provides one or more reasons
        /// for the failure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null && (this._failureReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImportedResourceId. 
        /// <para>
        /// The unique identifier that Amazon Lex assigned to the resource created by the import.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=10)]
        public string ImportedResourceId
        {
            get { return this._importedResourceId; }
            set { this._importedResourceId = value; }
        }

        // Check to see if ImportedResourceId property is set
        internal bool IsSetImportedResourceId()
        {
            return this._importedResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedResourceName. 
        /// <para>
        /// The name of the imported resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ImportedResourceName
        {
            get { return this._importedResourceName; }
            set { this._importedResourceName = value; }
        }

        // Check to see if ImportedResourceName property is set
        internal bool IsSetImportedResourceName()
        {
            return this._importedResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        /// The unique identifier of the described import.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string ImportId
        {
            get { return this._importId; }
            set { this._importId = value; }
        }

        // Check to see if ImportId property is set
        internal bool IsSetImportId()
        {
            return this._importId != null;
        }

        /// <summary>
        /// Gets and sets the property ImportStatus. 
        /// <para>
        /// The status of the import process. When the status is <c>Completed</c> the resource
        /// is imported and ready for use.
        /// </para>
        /// </summary>
        public ImportStatus ImportStatus
        {
            get { return this._importStatus; }
            set { this._importStatus = value; }
        }

        // Check to see if ImportStatus property is set
        internal bool IsSetImportStatus()
        {
            return this._importStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time that the import was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MergeStrategy. 
        /// <para>
        /// The strategy used when there was a name conflict between the imported resource and
        /// an existing resource. When the merge strategy is <c>FailOnConflict</c> existing resources
        /// are not overwritten and the import fails.
        /// </para>
        /// </summary>
        public MergeStrategy MergeStrategy
        {
            get { return this._mergeStrategy; }
            set { this._mergeStrategy = value; }
        }

        // Check to see if MergeStrategy property is set
        internal bool IsSetMergeStrategy()
        {
            return this._mergeStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSpecification. 
        /// <para>
        /// The specifications of the imported bot, bot locale, or custom vocabulary.
        /// </para>
        /// </summary>
        public ImportResourceSpecification ResourceSpecification
        {
            get { return this._resourceSpecification; }
            set { this._resourceSpecification = value; }
        }

        // Check to see if ResourceSpecification property is set
        internal bool IsSetResourceSpecification()
        {
            return this._resourceSpecification != null;
        }

    }
}