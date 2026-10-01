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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the attributes of an Batch compute environment's Amazon
    /// EKS configuration that can be updated. Currently <c>accessEntry</c> is the only attribute
    /// that you can change after the compute environment is created. For more information,
    /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/eks-access-entries.html">Amazon
    /// EKS access entry authentication</a> in the <i>Batch User Guide</i>.
    /// </summary>
    public partial class EksConfigurationUpdate
    {
        /// <summary>
        /// Gets and sets the property AccessEntry. 
        /// <para>
        /// The updated access entry configuration for the compute environment. Set <c>desiredState</c>
        /// to declare whether Batch will manage an access entry on the cluster. For the accepted
        /// values, see <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_EksAccessEntry.html">
        /// <c>EksAccessEntry</c> </a>.
        /// </para>
        /// </summary>
        public EksAccessEntry AccessEntry { get; set; }

        /// <summary>
        /// Checks to see if the AccessEntry property is set.
        /// </summary>
        internal bool IsSetAccessEntry() => this.AccessEntry != null;
    }
}
