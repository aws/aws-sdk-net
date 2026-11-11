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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Details for an Amazon EMR Studio, including ID, Name, VPC, and Description. To fetch
    /// additional details such as subnets, IAM roles, security groups, and tags for the Studio,
    /// use the <a>DescribeStudio</a> API.
    /// </summary>
    public partial class StudioSummary
    {
        /// <summary>
        /// Gets and sets the property AuthMode. 
        /// <para>
        /// Specifies whether the Studio authenticates users using IAM or IAM Identity Center.
        /// </para>
        /// </summary>
        public AuthMode AuthMode { get; set; }

        /// <summary>
        /// Checks to see if the AuthMode property is set.
        /// </summary>
        internal bool IsSetAuthMode() => this.AuthMode != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the Amazon EMR Studio was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The detailed description of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The ID of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string StudioId { get; set; }

        /// <summary>
        /// Checks to see if the StudioId property is set.
        /// </summary>
        internal bool IsSetStudioId() => this.StudioId != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The unique access URL of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the Virtual Private Cloud (Amazon VPC) associated with the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
