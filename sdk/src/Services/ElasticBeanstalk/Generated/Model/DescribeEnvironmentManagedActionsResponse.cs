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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// The result message containing a list of managed actions.
    /// </summary>
    public partial class DescribeEnvironmentManagedActionsResponse : AmazonWebServiceResponse
    {
        private List<ManagedAction> _managedActions = AWSConfigs.InitializeCollections ? new List<ManagedAction>() : null;

        /// <summary>
        /// Gets and sets the property ManagedActions. 
        /// <para>
        /// A list of upcoming and in-progress managed actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ManagedAction> ManagedActions
        {
            get { return this._managedActions; }
            set { this._managedActions = value; }
        }

        // Check to see if ManagedActions property is set
        internal bool IsSetManagedActions()
        {
            return this._managedActions != null && (this._managedActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}