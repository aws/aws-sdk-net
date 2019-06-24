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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// This is the response object from the DescribeComponent operation.
    /// </summary>
    public partial class DescribeComponentResponse : AmazonWebServiceResponse
    {
        private ApplicationComponent _applicationComponent;
        private List<string> _resourceList = new List<string>();

        /// <summary>
        /// Gets and sets the property ApplicationComponent.
        /// </summary>
        public ApplicationComponent ApplicationComponent
        {
            get { return this._applicationComponent; }
            set { this._applicationComponent = value; }
        }

        // Check to see if ApplicationComponent property is set
        internal bool IsSetApplicationComponent()
        {
            return this._applicationComponent != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceList. 
        /// <para>
        /// The list of resource ARNs that belong to the component.
        /// </para>
        /// </summary>
        public List<string> ResourceList
        {
            get { return this._resourceList; }
            set { this._resourceList = value; }
        }

        // Check to see if ResourceList property is set
        internal bool IsSetResourceList()
        {
            return this._resourceList != null && this._resourceList.Count > 0; 
        }

    }
}