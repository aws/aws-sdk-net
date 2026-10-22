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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateSourceNetworkStack operation. Associate
    /// a Source Network to an existing CloudFormation Stack and modify launch templates to
    /// use this network. Can be used for reverting to previously deployed CloudFormation
    /// stacks.
    /// </summary>
    public partial class AssociateSourceNetworkStackRequest : AmazonDrsRequest
    {
        /// <summary>
        /// Gets and sets the property CfnStackName. 
        /// <para>
        /// CloudFormation template to associate with a Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string CfnStackName { get; set; }

        /// <summary>
        /// Checks to see if the CfnStackName property is set.
        /// </summary>
        internal bool IsSetCfnStackName() => this.CfnStackName != null;

        /// <summary>
        /// Gets and sets the property SourceNetworkID. 
        /// <para>
        /// The Source Network ID to associate with CloudFormation template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 20)]
        public string SourceNetworkID { get; set; }

        /// <summary>
        /// Checks to see if the SourceNetworkID property is set.
        /// </summary>
        internal bool IsSetSourceNetworkID() => this.SourceNetworkID != null;
    }
}
