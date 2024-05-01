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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
        private LifeCycleLastTestFinalized _finalized;
        private LifeCycleLastTestInitiated _initiated;
        private LifeCycleLastTestReverted _reverted;

        /// <summary>
        /// Gets and sets the property Finalized. 
        /// <para>
        /// Lifecycle last Test finalized.
        /// </para>
        /// </summary>
        public LifeCycleLastTestFinalized Finalized
        {
            get { return this._finalized; }
            set { this._finalized = value; }
        }

        // Check to see if Finalized property is set
        internal bool IsSetFinalized()
        {
            return this._finalized != null;
        }

        /// <summary>
        /// Gets and sets the property Initiated. 
        /// <para>
        /// Lifecycle last Test initiated.
        /// </para>
        /// </summary>
        public LifeCycleLastTestInitiated Initiated
        {
            get { return this._initiated; }
            set { this._initiated = value; }
        }

        // Check to see if Initiated property is set
        internal bool IsSetInitiated()
        {
            return this._initiated != null;
        }

        /// <summary>
        /// Gets and sets the property Reverted. 
        /// <para>
        /// Lifecycle last Test reverted.
        /// </para>
        /// </summary>
        public LifeCycleLastTestReverted Reverted
        {
            get { return this._reverted; }
            set { this._reverted = value; }
        }

        // Check to see if Reverted property is set
        internal bool IsSetReverted()
        {
            return this._reverted != null;
        }

    }
}