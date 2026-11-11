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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the attributes to update on a Lightsail instance when it starts.
    /// </summary>
    public partial class InstanceAttributeUpdates
    {
        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The ID of the bundle to update the instance to.
        /// </para>
        ///  
        /// <para>
        /// Specify one of the following values for the bundle ID:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>auto</c> </b> – Updates an instance that runs on a previous-generation bundle
        /// to the newer-generation equivalent of that bundle. For example, specify <c>auto</c>
        /// to update an instance that runs on <c>small_2_0</c> to <c>small_3_0</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Newer-generation bundle ID</b> – Updates an instance that runs on a previous-generation
        /// bundle to the specified bundle. For example, specify <c>small_3_0</c> to update an
        /// instance that runs on <c>small_2_0</c> to <c>small_3_0</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Original bundle ID</b> – Updates an instance to the previous-generation bundle
        /// that it ran on before an earlier update. For example, specify <c>small_2_0</c> to
        /// return an instance that runs on <c>small_3_0</c> to <c>small_2_0</c>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The instance must be in the <c>stopped</c> state to update its bundle.
        /// </para>
        ///  
        /// <para>
        /// There is no additional cost to update an instance to a newer-generation bundle.
        /// </para>
        ///  </note>
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;
    }
}
