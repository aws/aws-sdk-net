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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
    /// This is the response object from the DescribeProject operation.
    /// </summary>
    public partial class DescribeProjectResponse : AmazonWebServiceResponse
    {
        private DateTime? _createDate;
        private string _createdBy;
        private string _datasetName;
        private string _lastModifiedBy;
        private DateTime? _lastModifiedDate;
        private string _name;
        private DateTime? _openDate;
        private string _openedBy;
        private string _recipeName;
        private string _resourceArn;
        private string _roleArn;
        private Sample _sample;
        private SessionStatus _sessionStatus;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time that the project was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate
        {
            get { return this._createDate; }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier (user name) of the user who created the project.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The dataset associated with the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The identifier (user name) of the user who last modified the project.
        /// </para>
        /// </summary>
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time that the project was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OpenDate. 
        /// <para>
        /// The date and time when the project was opened. 
        /// </para>
        /// </summary>
        public DateTime? OpenDate
        {
            get { return this._openDate; }
            set { this._openDate = value; }
        }

        // Check to see if OpenDate property is set
        internal bool IsSetOpenDate()
        {
            return this._openDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenedBy. 
        /// <para>
        /// The identifier (user name) of the user that opened the project for use. 
        /// </para>
        /// </summary>
        public string OpenedBy
        {
            get { return this._openedBy; }
            set { this._openedBy = value; }
        }

        // Check to see if OpenedBy property is set
        internal bool IsSetOpenedBy()
        {
            return this._openedBy != null;
        }

        /// <summary>
        /// Gets and sets the property RecipeName. 
        /// <para>
        /// The recipe associated with this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RecipeName
        {
            get { return this._recipeName; }
            set { this._recipeName = value; }
        }

        // Check to see if RecipeName property is set
        internal bool IsSetRecipeName()
        {
            return this._recipeName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the Identity and Access Management (IAM) role to be assumed when DataBrew
        /// runs the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property Sample.
        /// </summary>
        public Sample Sample
        {
            get { return this._sample; }
            set { this._sample = value; }
        }

        // Check to see if Sample property is set
        internal bool IsSetSample()
        {
            return this._sample != null;
        }

        /// <summary>
        /// Gets and sets the property SessionStatus. 
        /// <para>
        /// Describes the current state of the session:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISIONING</c> - allocating resources for the session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INITIALIZING</c> - getting the session ready for first use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ASSIGNED</c> - the session is ready for use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SessionStatus SessionStatus
        {
            get { return this._sessionStatus; }
            set { this._sessionStatus = value; }
        }

        // Check to see if SessionStatus property is set
        internal bool IsSetSessionStatus()
        {
            return this._sessionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata tags associated with this project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}