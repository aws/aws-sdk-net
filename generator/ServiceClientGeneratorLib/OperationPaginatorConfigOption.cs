using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    public class OperationPaginatorConfigOption
    {
        /// <summary>
        /// String name of the option
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// If the response wraps a member containing
        /// the config option, set this to the name of
        /// that member. This is a workaround for 
        /// SimpleWorkFlow
        /// </summary>
        public string WrappedResultMember { get; }

        /// <summary>
        /// Whether or not the provided option
        /// is a jmespath expression
        /// </summary>
        public bool IsJmesPath { get; }

        /// <summary>
        /// The member associated with the option
        /// </summary>
        public Member Member { get; }

        /// <summary>
        /// The property name of the member
        /// or the full name containing "." 
        /// if jmespath
        /// </summary>
        public string PropertyName
        {
            get
            {
                if (IsJmesPath)
                {
                    return Name;
                }
                if (WrappedResultMember != null)
                {
                    return $"{WrappedResultMember}.{Member.PropertyName}";
                }
                return Member.PropertyName;
            }
        }

        /// <summary>
        /// Support only result keys which are of type List
        /// </summary>
        public string ListItemType
        {
            get
            {
                var type = this.Member.DetermineType();
                var pattern = "^List\\<[a-zA-Z0-9]+\\>$";
                if (System.Text.RegularExpressions.Regex.IsMatch(type, pattern))
                {
                    return type.Substring(5, type.Length - 6);
                }
                return null;
            }
        }

        /// <summary>
        /// Whether or not this option is a list or a 
        /// dictionary. Mostly used for input/output token- checking
        /// if it is null or if it is empty if list or dictionary
        /// </summary>
        public bool IsListOrDict
        {
            get
            {
                return this.Member.IsList || this.Member.IsMap;
            }
        }

        /// <summary>
        /// Create a new OperationPaginatorConfigOption object
        /// and set whether or not it is a jmespath expression
        /// </summary>
        /// <param name="isJmesPath"> Whether or not it is a jmespath expression </param>
        /// <param name="member"> Member associated with the option </param>
        public OperationPaginatorConfigOption(bool isJmesPath, Member member)
        {
            IsJmesPath = isJmesPath;
            Member = member;
        }

        /// <summary>
        /// Create a new OperationPaginatorConfigOption object
        /// and set whether or not it is a jmespath expression
        /// </summary>
        /// <param name="isJmesPath"> Whether or not it is a jmespath expression </param>
        /// <param name="member"> Member associated with the option </param>
        /// <param name="name"> String name of the option as found in paginator config </param>
        public OperationPaginatorConfigOption(bool isJmesPath, Member member, string name)
            : this(isJmesPath, member)
        {
            Name = name;
        }

        /// <summary>
        /// Create a new OperationPaginatorConfigOption object
        /// and set whether or not it is a jmespath expression
        /// </summary>
        /// <param name="isJmesPath"> Whether or not it is a jmespath expression </param>
        /// <param name="member"> Member associated with the option </param>
        /// <param name="wrappedResultMember">If the result of this operation is wrapped in a response
        /// object. (workaround for SimpleWorkFlow) </param>
        public OperationPaginatorConfigOption(bool isJmesPath, string wrappedResultMember, Member member)
            : this(isJmesPath, member) 
        {
            WrappedResultMember = wrappedResultMember;
        }
    }
}
