//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Reflection {
    
    
    #region Component Designer generated code 
    public partial class FieldInfo_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Reflection.@__FieldInfo.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Reflection.FieldInfo))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Reflection.FieldInfo))]
    internal sealed partial class @__FieldInfo : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__FieldInfo(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.Reflection.@__FieldInfo.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__FieldInfo);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetFieldFromHandle", "GetFieldFromHandle0", "(Lsystem/ValueType;)Lsystem/reflection/FieldInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetFieldFromHandle", "GetFieldFromHandle1", "(Lsystem/ValueType;Lsystem/ValueType;)Lsystem/reflection/FieldInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetRequiredCustomModifiers", "GetRequiredCustomModifiers2", "()[Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetOptionalCustomModifiers", "GetOptionalCustomModifiers3", "()[Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getFieldHandle", "FieldHandle4", "()Lsystem/ValueType;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getFieldType", "FieldType5", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetValue", "GetValue6", "(Lsystem/Object;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetRawConstantValue", "GetRawConstantValue7", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "SetValue", "SetValue8", "(Lsystem/Object;Lsystem/Object;Lsystem/reflection/BindingFlags;Ljava/lang/Object;" +
                        "Lsystem/ICloneable;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getAttributes", "Attributes9", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "SetValue", "SetValue10", "(Lsystem/Object;Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isPublic", "IsPublic11", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isPrivate", "IsPrivate12", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isFamily", "IsFamily13", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isAssembly", "IsAssembly14", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isFamilyAndAssembly", "IsFamilyAndAssembly15", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isFamilyOrAssembly", "IsFamilyOrAssembly16", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isStatic", "IsStatic17", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isInitOnly", "IsInitOnly18", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isLiteral", "IsLiteral19", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isNotSerialized", "IsNotSerialized20", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isSpecialName", "IsSpecialName21", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isPinvokeImpl", "IsPinvokeImpl22", "()Z"));
            return methods;
        }
        
        private static global::System.IntPtr GetFieldFromHandle0(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr handle) {
            // (Lsystem/ValueType;)Lsystem/reflection/FieldInfo;
            // (LSystem/RuntimeFieldHandle;)LSystem/Reflection/FieldInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, global::System.Reflection.FieldInfo.GetFieldFromHandle(global::net.sf.jni4net.utils.Convertor.J2C<global::System.RuntimeFieldHandle>(__env, handle)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetFieldFromHandle1(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr handle, global::System.IntPtr declaringType) {
            // (Lsystem/ValueType;Lsystem/ValueType;)Lsystem/reflection/FieldInfo;
            // (LSystem/RuntimeFieldHandle;LSystem/RuntimeTypeHandle;)LSystem/Reflection/FieldInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, global::System.Reflection.FieldInfo.GetFieldFromHandle(global::net.sf.jni4net.utils.Convertor.J2C<global::System.RuntimeFieldHandle>(__env, handle), global::net.sf.jni4net.utils.Convertor.J2C<global::System.RuntimeTypeHandle>(__env, declaringType)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetRequiredCustomModifiers2(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()[Lsystem/Type;
            // ()[LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real.GetRequiredCustomModifiers());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetOptionalCustomModifiers3(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()[Lsystem/Type;
            // ()[LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real.GetOptionalCustomModifiers());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr FieldHandle4(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/ValueType;
            // ()LSystem/RuntimeFieldHandle;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real.FieldHandle);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr FieldType5(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real.FieldType);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetValue6(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr obj) {
            // (Lsystem/Object;)Lsystem/Object;
            // (LSystem/Object;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real.GetValue(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(__env, obj)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetRawConstantValue7(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real.GetRawConstantValue());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static void SetValue8(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr obj, global::System.IntPtr value, global::System.IntPtr invokeAttr, global::System.IntPtr binder, global::System.IntPtr culture) {
            // (Lsystem/Object;Lsystem/Object;Lsystem/reflection/BindingFlags;Ljava/lang/Object;Lsystem/ICloneable;)V
            // (LSystem/Object;LSystem/Object;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;LSystem/Globalization/CultureInfo;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            real.SetValue(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(__env, obj), global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(__env, value), global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.BindingFlags>(__env, invokeAttr), global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.Binder>(__env, binder), global::net.sf.jni4net.utils.Convertor.J2C<global::System.Globalization.CultureInfo>(__env, culture));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static global::System.IntPtr Attributes9(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/Reflection/FieldAttributes;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real.Attributes);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static void SetValue10(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr obj, global::System.IntPtr value) {
            // (Lsystem/Object;Lsystem/Object;)V
            // (LSystem/Object;LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            real.SetValue(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(__env, obj), global::net.sf.jni4net.utils.Convertor.J2C<global::System.Object>(__env, value));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static bool IsPublic11(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return real.IsPublic;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsPrivate12(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return real.IsPrivate;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsFamily13(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return real.IsFamily;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsAssembly14(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return real.IsAssembly;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsFamilyAndAssembly15(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return real.IsFamilyAndAssembly;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsFamilyOrAssembly16(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return real.IsFamilyOrAssembly;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsStatic17(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return real.IsStatic;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsInitOnly18(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return real.IsInitOnly;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsLiteral19(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return real.IsLiteral;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsNotSerialized20(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return real.IsNotSerialized;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsSpecialName21(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return real.IsSpecialName;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsPinvokeImpl22(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Reflection.FieldInfo real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Reflection.FieldInfo>(__env, @__obj);
            return real.IsPinvokeImpl;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.Reflection.@__FieldInfo(env);
            }
        }
    }
    #endregion
}
