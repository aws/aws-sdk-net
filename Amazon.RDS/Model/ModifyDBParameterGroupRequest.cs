/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBParameterGroup operation.
    /// <para> This API modifies the parameters of a DBParameterGroup. To
    /// modify more than one parameter submit a list of the following:
    /// ParameterName, ParameterValue, and ApplyMethod. A maximum of 20
    /// parameters can be modified in a single request. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.ModifyDBParameterGroup"/>
    public class ModifyDBParameterGroupRequest : AmazonWebServiceRequest
    {
        private string dBParameterGroupName;
        private List<Parameter> parameters = new List<Parameter>();

        /// <summary>
        /// The name of the database parameter group.
        ///  
        /// </summary>
        public string DBParameterGroupName
        {
            get { return this.dBParameterGroupName; }
            set { this.dBParameterGroupName = value; }
        }

        /// <summary>
        /// Sets the DBParameterGroupName property
        /// </summary>
        /// <param name="dBParameterGroupName">The value to set for the DBParameterGroupName property </param>
        /// <returns>this instance</returns>
        public ModifyDBParameterGroupRequest WithDBParameterGroupName(string dBParameterGroupName)
        {
            this.dBParameterGroupName = dBParameterGroupName;
            return this;
        }
            
        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this.dBParameterGroupName != null;       
        }

        /// <summary>
        /// An array of parameter names, values, and the apply method for the
        /// parameter update. At least one parameter name, value, and apply method
        /// must be supplied; subsequent arguments are optional. A maximum of 20
        /// parameters may be modified in a single request.
        ///  
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this.parameters; }
            set { this.parameters = value; }
        }
        /// <summary>
        /// Adds elements to the Parameters collection
        /// </summary>
        /// <param name="parameters">The values to add to the Parameters collection </param>
        /// <returns>this instance</returns>
        public ModifyDBParameterGroupRequest WithParameters(params Parameter[] parameters)
        {
            foreach (Parameter element in parameters)
            {
                this.parameters.Add(element);
            }

            return this;
        }
        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this.parameters.Count > 0;       
        }
    }
}
    
