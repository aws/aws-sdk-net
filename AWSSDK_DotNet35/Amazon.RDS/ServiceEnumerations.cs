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


namespace Amazon.RDS
{


    /// <summary>Apply Method
    /// </summary>
    public class ApplyMethod : ConstantClass
    {


       /// <summary>Constant Immediate for ApplyMethod
       /// </summary>
        public static readonly ApplyMethod Immediate = new ApplyMethod("immediate");
    

       /// <summary>Constant PendingReboot for ApplyMethod
       /// </summary>
        public static readonly ApplyMethod PendingReboot = new ApplyMethod("pending-reboot");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ApplyMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplyMethod FindValue(string value)
        {
            return FindValue<ApplyMethod>(value);
        }

        public static implicit operator ApplyMethod(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Source Type
    /// </summary>
    public class SourceType : ConstantClass
    {


       /// <summary>Constant DbInstance for SourceType
       /// </summary>
        public static readonly SourceType DbInstance = new SourceType("db-instance");
    

       /// <summary>Constant DbParameterGroup for SourceType
       /// </summary>
        public static readonly SourceType DbParameterGroup = new SourceType("db-parameter-group");
    

       /// <summary>Constant DbSecurityGroup for SourceType
       /// </summary>
        public static readonly SourceType DbSecurityGroup = new SourceType("db-security-group");
    

       /// <summary>Constant DbSnapshot for SourceType
       /// </summary>
        public static readonly SourceType DbSnapshot = new SourceType("db-snapshot");
    

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
        
