/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Describes a policy used by EFS lifecycle management to transition files to the Infrequent
    /// Access (IA) storage class.
    /// </summary>
    public partial class LifecyclePolicy
    {
        private TransitionToIARules _transitionToIA;

        /// <summary>
        /// Gets and sets the property TransitionToIA. 
        /// <para>
        /// A value that indicates how long it takes to transition files to the IA storage class.
        /// Currently, the only valid value is <code>AFTER_30_DAYS</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>AFTER_30_DAYS</code> indicates files that have not been read from or written
        /// to for 30 days are transitioned from the Standard storage class to the IA storage
        /// class. Metadata operations such as listing the contents of a directory don't count
        /// as a file access event.
        /// </para>
        /// </summary>
        public TransitionToIARules TransitionToIA
        {
            get { return this._transitionToIA; }
            set { this._transitionToIA = value; }
        }

        // Check to see if TransitionToIA property is set
        internal bool IsSetTransitionToIA()
        {
            return this._transitionToIA != null;
        }

    }
}