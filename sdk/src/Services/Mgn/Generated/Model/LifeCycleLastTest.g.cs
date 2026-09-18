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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Lifecycle last Test.
    /// </summary>
    public partial class LifeCycleLastTest
    {
        /// <summary>
        /// Gets and sets the property Finalized. 
        /// <para>
        /// Lifecycle last Test finalized.
        /// </para>
        /// </summary>
        public LifeCycleLastTestFinalized Finalized { get; set; }

        /// <summary>
        /// Checks to see if the Finalized property is set.
        /// </summary>
        internal bool IsSetFinalized() => this.Finalized != null;

        /// <summary>
        /// Gets and sets the property Initiated. 
        /// <para>
        /// Lifecycle last Test initiated.
        /// </para>
        /// </summary>
        public LifeCycleLastTestInitiated Initiated { get; set; }

        /// <summary>
        /// Checks to see if the Initiated property is set.
        /// </summary>
        internal bool IsSetInitiated() => this.Initiated != null;

        /// <summary>
        /// Gets and sets the property Reverted. 
        /// <para>
        /// Lifecycle last Test reverted.
        /// </para>
        /// </summary>
        public LifeCycleLastTestReverted Reverted { get; set; }

        /// <summary>
        /// Checks to see if the Reverted property is set.
        /// </summary>
        internal bool IsSetReverted() => this.Reverted != null;
    }
}
