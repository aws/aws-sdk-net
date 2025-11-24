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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Defines the various categories of drift that can occur for an enabled control resource.
    /// </summary>
    public partial class EnabledControlDriftTypes
    {
        private EnabledControlInheritanceDrift _inheritance;
        private EnabledControlResourceDrift _resource;

        /// <summary>
        /// Gets and sets the property Inheritance. 
        /// <para>
        /// Indicates drift related to inheritance configuration between parent and child controls.
        /// </para>
        /// </summary>
        public EnabledControlInheritanceDrift Inheritance
        {
            get { return this._inheritance; }
            set { this._inheritance = value; }
        }

        // Check to see if Inheritance property is set
        internal bool IsSetInheritance()
        {
            return this._inheritance != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// Indicates drift related to the underlying Amazon Web Services resources managed by
        /// the control.
        /// </para>
        /// </summary>
        public EnabledControlResourceDrift Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}