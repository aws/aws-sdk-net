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


namespace Amazon.ImportExport
{


    /// <summary>Job Type
    /// </summary>
    public class JobType : ConstantClass
    {


       /// <summary>Constant Export for JobType
       /// </summary>
        public static readonly JobType Export = new JobType("Export");
    

       /// <summary>Constant Import for JobType
       /// </summary>
        public static readonly JobType Import = new JobType("Import");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public JobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobType FindValue(string value)
        {
            return FindValue<JobType>(value);
        }

        public static implicit operator JobType(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
