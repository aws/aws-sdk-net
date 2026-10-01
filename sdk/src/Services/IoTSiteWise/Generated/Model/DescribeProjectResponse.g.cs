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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeProject operation.
    /// </summary>
    public partial class DescribeProjectResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property PortalId. 
        /// <para>
        /// The ID of the portal that the project is in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string PortalId { get; set; }

        /// <summary>
        /// Checks to see if the PortalId property is set.
        /// </summary>
        internal bool IsSetPortalId() => this.PortalId != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string ProjectArn { get; set; }

        /// <summary>
        /// Checks to see if the ProjectArn property is set.
        /// </summary>
        internal bool IsSetProjectArn() => this.ProjectArn != null;

        /// <summary>
        /// Gets and sets the property ProjectCreationDate. 
        /// <para>
        /// The date the project was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ProjectCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the ProjectCreationDate property is set.
        /// </summary>
        internal bool IsSetProjectCreationDate() => this.ProjectCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ProjectDescription. 
        /// <para>
        /// The project's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ProjectDescription { get; set; }

        /// <summary>
        /// Checks to see if the ProjectDescription property is set.
        /// </summary>
        internal bool IsSetProjectDescription() => this.ProjectDescription != null;

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Checks to see if the ProjectId property is set.
        /// </summary>
        internal bool IsSetProjectId() => this.ProjectId != null;

        /// <summary>
        /// Gets and sets the property ProjectLastUpdateDate. 
        /// <para>
        /// The date the project was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ProjectLastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the ProjectLastUpdateDate property is set.
        /// </summary>
        internal bool IsSetProjectLastUpdateDate() => this.ProjectLastUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;
    }
}
