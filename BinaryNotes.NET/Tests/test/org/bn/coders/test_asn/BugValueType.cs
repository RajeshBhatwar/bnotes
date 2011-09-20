
//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System;
using org.bn.attributes;
using org.bn.attributes.constraints;
using org.bn.coders;
using org.bn.types;
using org.bn;

namespace test.org.bn.coders.test_asn {


    [ASN1PreparedElement]
    [ASN1Choice ( Name = "BugValueType") ]
    public class BugValueType : IASN1PreparedElement {
                    
        
	private BugPrimitive bugPrimitive_ ;
        private bool  bugPrimitive_selected = false ;
        
                
        
        [ASN1Element ( Name = "bugPrimitive", IsOptional =  false , HasTag =  true, Tag = 0 , HasDefaultValue =  false )  ]
    
        public BugPrimitive BugPrimitive
        {
            get { return bugPrimitive_; }
            set { selectBugPrimitive(value); }
        }
        
                
          
        
	private BugEnum bugEnum_ ;
        private bool  bugEnum_selected = false ;
        
                
        
        [ASN1Element ( Name = "bugEnum", IsOptional =  false , HasTag =  true, Tag = 1 , HasDefaultValue =  false )  ]
    
        public BugEnum BugEnum
        {
            get { return bugEnum_; }
            set { selectBugEnum(value); }
        }
        
                
          
        
	private BugSequenceType bugSequence_ ;
        private bool  bugSequence_selected = false ;
        
                
        
        [ASN1Element ( Name = "bugSequence", IsOptional =  false , HasTag =  true, Tag = 2 , HasDefaultValue =  false )  ]
    
        public BugSequenceType BugSequence
        {
            get { return bugSequence_; }
            set { selectBugSequence(value); }
        }
        
                
          
        public bool isBugPrimitiveSelected () {
            return this.bugPrimitive_selected ;
        }

        


        public void selectBugPrimitive (BugPrimitive val) {
            this.bugPrimitive_ = val;
            this.bugPrimitive_selected = true;
            
            
                    this.bugEnum_selected = false;
                
                    this.bugSequence_selected = false;
                            
        }
        
          
        public bool isBugEnumSelected () {
            return this.bugEnum_selected ;
        }

        


        public void selectBugEnum (BugEnum val) {
            this.bugEnum_ = val;
            this.bugEnum_selected = true;
            
            
                    this.bugPrimitive_selected = false;
                
                    this.bugSequence_selected = false;
                            
        }
        
          
        public bool isBugSequenceSelected () {
            return this.bugSequence_selected ;
        }

        


        public void selectBugSequence (BugSequenceType val) {
            this.bugSequence_ = val;
            this.bugSequence_selected = true;
            
            
                    this.bugPrimitive_selected = false;
                
                    this.bugEnum_selected = false;
                            
        }
        
  

            public void initWithDefaults()
	    {
	    }

            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(BugValueType));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

    }
            
}
