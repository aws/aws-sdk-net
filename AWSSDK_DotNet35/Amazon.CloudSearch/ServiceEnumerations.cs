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


namespace Amazon.CloudSearch
{


    /// <summary>Index Field Type
    /// </summary>
    public class IndexFieldType : ConstantClass
    {


       /// <summary>Constant Literal for IndexFieldType
       /// </summary>
        public static readonly IndexFieldType Literal = new IndexFieldType("literal");
    

       /// <summary>Constant Text for IndexFieldType
       /// </summary>
        public static readonly IndexFieldType Text = new IndexFieldType("text");
    

       /// <summary>Constant Uint for IndexFieldType
       /// </summary>
        public static readonly IndexFieldType Uint = new IndexFieldType("uint");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public IndexFieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndexFieldType FindValue(string value)
        {
            return FindValue<IndexFieldType>(value);
        }

        public static implicit operator IndexFieldType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Option State
    /// </summary>
    public class OptionState : ConstantClass
    {


       /// <summary>Constant Active for OptionState
       /// </summary>
        public static readonly OptionState Active = new OptionState("Active");
    

       /// <summary>Constant Processing for OptionState
       /// </summary>
        public static readonly OptionState Processing = new OptionState("Processing");
    

       /// <summary>Constant RequiresIndexDocuments for OptionState
       /// </summary>
        public static readonly OptionState RequiresIndexDocuments = new OptionState("RequiresIndexDocuments");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public OptionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OptionState FindValue(string value)
        {
            return FindValue<OptionState>(value);
        }

        public static implicit operator OptionState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Source Data Function
    /// </summary>
    public class SourceDataFunction : ConstantClass
    {


       /// <summary>Constant Copy for SourceDataFunction
       /// </summary>
        public static readonly SourceDataFunction Copy = new SourceDataFunction("Copy");
    

       /// <summary>Constant Map for SourceDataFunction
       /// </summary>
        public static readonly SourceDataFunction Map = new SourceDataFunction("Map");
    

       /// <summary>Constant TrimTitle for SourceDataFunction
       /// </summary>
        public static readonly SourceDataFunction TrimTitle = new SourceDataFunction("TrimTitle");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SourceDataFunction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceDataFunction FindValue(string value)
        {
            return FindValue<SourceDataFunction>(value);
        }

        public static implicit operator SourceDataFunction(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
