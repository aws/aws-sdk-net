/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ResetClusterParameterGroup operation.
    /// <para> Sets one or more parameters of the specified parameter group to their default values and sets the source values of the parameters to
    /// "engine-default". To reset the entire parameter group specify the <i>ResetAllParameters</i> parameter. For parameter changes to take effect
    /// you must reboot any associated clusters. </para>
    /// </summary>
    public partial class ResetClusterParameterGroupRequest : AmazonRedshiftRequest
    {
        private string parameterGroupName;
        private bool? resetAllParameters;
        private List<Parameter> parameters = new List<Parameter>();


        /// <summary>
        /// The name of the cluster parameter group to be reset.
        ///  
        /// </summary>
        public string ParameterGroupName
        {
            get { return this.parameterGroupName; }
            set { this.parameterGroupName = value; }
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this.parameterGroupName != null;
        }

        /// <summary>
        /// If <c>true</c>, all parameters in the specified parameter group will be reset to their default values. Default: <c>true</c>
        ///  
        /// </summary>
        public bool ResetAllParameters
        {
            get { return this.resetAllParameters ?? default(bool); }
            set { this.resetAllParameters = value; }
        }

        // Check to see if ResetAllParameters property is set
        internal bool IsSetResetAllParameters()
        {
            return this.resetAllParameters.HasValue;
        }

        /// <summary>
        /// An array of names of parameters to be reset. If <i>ResetAllParameters</i> option is not used, then at least one parameter name must be
        /// supplied. Constraints: A maximum of 20 parameters can be reset in a single request.
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
    
