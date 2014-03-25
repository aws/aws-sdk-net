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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Describes the default cluster parameters for a parameter group family. </para>
    /// </summary>
    public partial class DefaultClusterParameters : AmazonWebServiceResponse
    {
        
        private string parameterGroupFamily;
        private string marker;
        private List<Parameter> parameters = new List<Parameter>();


        /// <summary>
        /// The name of the cluster parameter group family to which the engine default parameters apply.
        ///  
        /// </summary>
        public string ParameterGroupFamily
        {
            get { return this.parameterGroupFamily; }
            set { this.parameterGroupFamily = value; }
        }

        // Check to see if ParameterGroupFamily property is set
        internal bool IsSetParameterGroupFamily()
        {
            return this.parameterGroupFamily != null;
        }

        /// <summary>
        /// A value that indicates the starting point for the next set of response records in a subsequent request. If a value is returned in a
        /// response, you can retrieve the next set of records by providing this returned marker value in the <c>Marker</c> parameter and retrying the
        /// command. If the <c>Marker</c> field is empty, all response records have been retrieved for the request.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// The list of cluster default parameters.
        ///  
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this.parameters; }
            set { this.parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this.parameters.Count > 0;
        }
    }
}
