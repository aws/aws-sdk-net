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

using Amazon.Runtime;


namespace Amazon.Redshift
{


    /// <summary>Source Type
    /// </summary>
    public class SourceType : ConstantClass
    {


       /// <summary>Constant Cluster for SourceType
       /// </summary>
        public static readonly SourceType Cluster = new SourceType("cluster");
    

       /// <summary>Constant ClusterParameterGroup for SourceType
       /// </summary>
        public static readonly SourceType ClusterParameterGroup = new SourceType("cluster-parameter-group");
    

       /// <summary>Constant ClusterSecurityGroup for SourceType
       /// </summary>
        public static readonly SourceType ClusterSecurityGroup = new SourceType("cluster-security-group");
    

       /// <summary>Constant ClusterSnapshot for SourceType
       /// </summary>
        public static readonly SourceType ClusterSnapshot = new SourceType("cluster-snapshot");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
