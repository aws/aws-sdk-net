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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResourceCollection operation.
    /// Updates the collection of resources that DevOps Guru analyzes. The two types of Amazon
    /// Web Services resource collections supported are Amazon Web Services CloudFormation
    /// stacks and Amazon Web Services resources that contain the same Amazon Web Services
    /// tag. DevOps Guru can be configured to analyze the Amazon Web Services resources that
    /// are defined in the stacks or that are tagged using the same tag <i>key</i>. You can
    /// specify up to 500 Amazon Web Services CloudFormation stacks. This method also creates
    /// the IAM role required for you to use DevOps Guru.
    /// </summary>
    public partial class UpdateResourceCollectionRequest : AmazonDevOpsGuruRequest
    {
        private UpdateResourceCollectionAction _action;
        private UpdateResourceCollectionFilter _resourceCollection;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        ///  Specifies if the resource collection in the request is added or deleted to the resource
        /// collection. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateResourceCollectionAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCollection.
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateResourceCollectionFilter ResourceCollection
        {
            get { return this._resourceCollection; }
            set { this._resourceCollection = value; }
        }

        // Check to see if ResourceCollection property is set
        internal bool IsSetResourceCollection()
        {
            return this._resourceCollection != null;
        }

    }
}