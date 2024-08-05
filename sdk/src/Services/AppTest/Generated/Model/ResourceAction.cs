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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Specifies a resource action.
    /// </summary>
    public partial class ResourceAction
    {
        private CloudFormationAction _cloudFormationAction;
        private M2ManagedApplicationAction _m2ManagedApplicationAction;
        private M2NonManagedApplicationAction _m2NonManagedApplicationAction;

        /// <summary>
        /// Gets and sets the property CloudFormationAction. 
        /// <para>
        /// The CloudFormation action of the resource action.
        /// </para>
        /// </summary>
        public CloudFormationAction CloudFormationAction
        {
            get { return this._cloudFormationAction; }
            set { this._cloudFormationAction = value; }
        }

        // Check to see if CloudFormationAction property is set
        internal bool IsSetCloudFormationAction()
        {
            return this._cloudFormationAction != null;
        }

        /// <summary>
        /// Gets and sets the property M2ManagedApplicationAction. 
        /// <para>
        /// The AWS Mainframe Modernization managed application action of the resource action.
        /// </para>
        /// </summary>
        public M2ManagedApplicationAction M2ManagedApplicationAction
        {
            get { return this._m2ManagedApplicationAction; }
            set { this._m2ManagedApplicationAction = value; }
        }

        // Check to see if M2ManagedApplicationAction property is set
        internal bool IsSetM2ManagedApplicationAction()
        {
            return this._m2ManagedApplicationAction != null;
        }

        /// <summary>
        /// Gets and sets the property M2NonManagedApplicationAction. 
        /// <para>
        /// The AWS Mainframe Modernization non-managed application action of the resource action.
        /// </para>
        /// </summary>
        public M2NonManagedApplicationAction M2NonManagedApplicationAction
        {
            get { return this._m2NonManagedApplicationAction; }
            set { this._m2NonManagedApplicationAction = value; }
        }

        // Check to see if M2NonManagedApplicationAction property is set
        internal bool IsSetM2NonManagedApplicationAction()
        {
            return this._m2NonManagedApplicationAction != null;
        }

    }
}