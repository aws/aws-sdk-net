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


namespace Amazon.CloudFront
{


    /// <summary>Item Selection
    /// </summary>
    public class ItemSelection : ConstantClass
    {


       /// <summary>Constant All for ItemSelection
       /// </summary>
        public static readonly ItemSelection All = new ItemSelection("all");
    

       /// <summary>Constant None for ItemSelection
       /// </summary>
        public static readonly ItemSelection None = new ItemSelection("none");
    

       /// <summary>Constant Whitelist for ItemSelection
       /// </summary>
        public static readonly ItemSelection Whitelist = new ItemSelection("whitelist");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ItemSelection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ItemSelection FindValue(string value)
        {
            return FindValue<ItemSelection>(value);
        }

        public static implicit operator ItemSelection(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Method
    /// </summary>
    public class Method : ConstantClass
    {


       /// <summary>Constant DELETE for Method
       /// </summary>
        public static readonly Method DELETE = new Method("DELETE");
    

       /// <summary>Constant GET for Method
       /// </summary>
        public static readonly Method GET = new Method("GET");
    

       /// <summary>Constant HEAD for Method
       /// </summary>
        public static readonly Method HEAD = new Method("HEAD");
    

       /// <summary>Constant OPTIONS for Method
       /// </summary>
        public static readonly Method OPTIONS = new Method("OPTIONS");
    

       /// <summary>Constant PATCH for Method
       /// </summary>
        public static readonly Method PATCH = new Method("PATCH");
    

       /// <summary>Constant POST for Method
       /// </summary>
        public static readonly Method POST = new Method("POST");
    

       /// <summary>Constant PUT for Method
       /// </summary>
        public static readonly Method PUT = new Method("PUT");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Method(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Method FindValue(string value)
        {
            return FindValue<Method>(value);
        }

        public static implicit operator Method(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Origin Protocol Policy
    /// </summary>
    public class OriginProtocolPolicy : ConstantClass
    {


       /// <summary>Constant HttpOnly for OriginProtocolPolicy
       /// </summary>
        public static readonly OriginProtocolPolicy HttpOnly = new OriginProtocolPolicy("http-only");
    

       /// <summary>Constant MatchViewer for OriginProtocolPolicy
       /// </summary>
        public static readonly OriginProtocolPolicy MatchViewer = new OriginProtocolPolicy("match-viewer");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public OriginProtocolPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginProtocolPolicy FindValue(string value)
        {
            return FindValue<OriginProtocolPolicy>(value);
        }

        public static implicit operator OriginProtocolPolicy(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Price Class
    /// </summary>
    public class PriceClass : ConstantClass
    {


       /// <summary>Constant PriceClass_100 for PriceClass
       /// </summary>
        public static readonly PriceClass PriceClass_100 = new PriceClass("PriceClass_100");
    

       /// <summary>Constant PriceClass_200 for PriceClass
       /// </summary>
        public static readonly PriceClass PriceClass_200 = new PriceClass("PriceClass_200");
    

       /// <summary>Constant PriceClass_All for PriceClass
       /// </summary>
        public static readonly PriceClass PriceClass_All = new PriceClass("PriceClass_All");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PriceClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PriceClass FindValue(string value)
        {
            return FindValue<PriceClass>(value);
        }

        public static implicit operator PriceClass(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Viewer Protocol Policy
    /// </summary>
    public class ViewerProtocolPolicy : ConstantClass
    {


       /// <summary>Constant AllowAll for ViewerProtocolPolicy
       /// </summary>
        public static readonly ViewerProtocolPolicy AllowAll = new ViewerProtocolPolicy("allow-all");
    

       /// <summary>Constant HttpsOnly for ViewerProtocolPolicy
       /// </summary>
        public static readonly ViewerProtocolPolicy HttpsOnly = new ViewerProtocolPolicy("https-only");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ViewerProtocolPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ViewerProtocolPolicy FindValue(string value)
        {
            return FindValue<ViewerProtocolPolicy>(value);
        }

        public static implicit operator ViewerProtocolPolicy(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
