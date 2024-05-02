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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeProject operation.
    /// </summary>
    public partial class DescribeProjectResponse : AmazonWebServiceResponse
    {
        private string _portalId;
        private string _projectArn;
        private DateTime? _projectCreationDate;
        private string _projectDescription;
        private string _projectId;
        private DateTime? _projectLastUpdateDate;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property PortalId. 
        /// <para>
        /// The ID of the portal that the project is in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PortalId
        {
            get { return this._portalId; }
            set { this._portalId = value; }
        }

        // Check to see if PortalId property is set
        internal bool IsSetPortalId()
        {
            return this._portalId != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the project, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:project/${ProjectId}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectCreationDate. 
        /// <para>
        /// The date the project was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ProjectCreationDate
        {
            get { return this._projectCreationDate; }
            set { this._projectCreationDate = value; }
        }

        // Check to see if ProjectCreationDate property is set
        internal bool IsSetProjectCreationDate()
        {
            return this._projectCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectDescription. 
        /// <para>
        /// The project's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ProjectDescription
        {
            get { return this._projectDescription; }
            set { this._projectDescription = value; }
        }

        // Check to see if ProjectDescription property is set
        internal bool IsSetProjectDescription()
        {
            return this._projectDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }

        // Check to see if ProjectId property is set
        internal bool IsSetProjectId()
        {
            return this._projectId != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectLastUpdateDate. 
        /// <para>
        /// The date the project was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ProjectLastUpdateDate
        {
            get { return this._projectLastUpdateDate; }
            set { this._projectLastUpdateDate = value; }
        }

        // Check to see if ProjectLastUpdateDate property is set
        internal bool IsSetProjectLastUpdateDate()
        {
            return this._projectLastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

    }
}