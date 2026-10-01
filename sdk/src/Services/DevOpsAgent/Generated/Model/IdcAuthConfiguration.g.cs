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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Configuration for AWS Identity Center (IdC) authentication flow for the Operator App.
    /// </summary>
    public partial class IdcAuthConfiguration
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the Operator App IdC auth flow was enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property IdcApplicationArn. 
        /// <para>
        /// The IdC application Arn created for IdC auth
        /// </para>
        /// </summary>
        public string IdcApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the IdcApplicationArn property is set.
        /// </summary>
        internal bool IsSetIdcApplicationArn() => this.IdcApplicationArn != null;

        /// <summary>
        /// Gets and sets the property IdcInstanceArn. 
        /// <para>
        /// The IdC instance Arn used to create an IdC auth application
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IdcInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdcInstanceArn property is set.
        /// </summary>
        internal bool IsSetIdcInstanceArn() => this.IdcInstanceArn != null;

        /// <summary>
        /// Gets and sets the property OperatorAppRoleArn. 
        /// <para>
        /// The IAM role end users assume to access AIDevOps APIs
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OperatorAppRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the OperatorAppRoleArn property is set.
        /// </summary>
        internal bool IsSetOperatorAppRoleArn() => this.OperatorAppRoleArn != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the Operator App IdC auth flow was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
