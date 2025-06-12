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
    /// A list of available AWS Elastic Beanstalk solution stacks.
    /// </summary>
    public partial class ListAvailableSolutionStacksResponse : AmazonWebServiceResponse
    {
        private List<SolutionStackDescription> _solutionStackDetails = AWSConfigs.InitializeCollections ? new List<SolutionStackDescription>() : null;
        private List<string> _solutionStacks = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SolutionStackDetails. 
        /// <para>
        ///  A list of available solution stacks and their <a>SolutionStackDescription</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SolutionStackDescription> SolutionStackDetails
        {
            get { return this._solutionStackDetails; }
            set { this._solutionStackDetails = value; }
        }

        // Check to see if SolutionStackDetails property is set
        internal bool IsSetSolutionStackDetails()
        {
            return this._solutionStackDetails != null && (this._solutionStackDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SolutionStacks. 
        /// <para>
        /// A list of available solution stacks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SolutionStacks
        {
            get { return this._solutionStacks; }
            set { this._solutionStacks = value; }
        }

        // Check to see if SolutionStacks property is set
        internal bool IsSetSolutionStacks()
        {
            return this._solutionStacks != null && (this._solutionStacks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}